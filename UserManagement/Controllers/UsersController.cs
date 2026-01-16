using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserManagement.BLL.Interfaces;
using UserManagement.Model.DTOs;
namespace UserManagement.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ILogger<UsersController> _logger;

        public UsersController(IUserService userService, ILogger<UsersController> logger)
        {
            _userService = userService;
            _logger = logger;
        }

        /// <summary>
        /// Create a new user
        /// </summary>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public async Task<ActionResult<ApiResponse<UserResponseDto>>> CreateUser(
            [FromBody] UserRequestDto userDto)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToArray();

                return BadRequest(new ApiResponse<UserResponseDto>(
                    false,
                    "Validation failed ",
                    errors));
            }

            try
            {
                var createdUser = await _userService.CreateUserAsync(userDto);

                var response = new ApiResponse<UserResponseDto>(
                    true,
                    "User created successfully",
                    createdUser);

                return CreatedAtAction(nameof(GetUserById),
                    new { id = createdUser.Id },
                    response);
            }
            catch (InvalidOperationException ex)
            {
                _logger.LogWarning($"Conflict while creating user: {ex.Message}");
                return Conflict(new ApiResponse<UserResponseDto>(
                    false,
                    ex.Message));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error creating user: {ex.Message}");
                return StatusCode(500, new ApiResponse<UserResponseDto>(
                    false,
                    "An error occurred while creating user"));
            }
        }

        /// <summary>
        /// Get user by ID
        /// </summary>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ApiResponse<UserResponseDto>>> GetUserById(Guid id)
        {
            try
            {
                var user = await _userService.GetUserByIdAsync(id);

                var response = new ApiResponse<UserResponseDto>(
                    true,
                    "User retrieved successfully",
                    user);

                return Ok(response);
            }
            catch (KeyNotFoundException ex)
            {
                _logger.LogWarning($"User not found: {ex.Message}");
                return NotFound(new ApiResponse<UserResponseDto>(
                    false,
                    ex.Message));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error retrieving user: {ex.Message}");
                return StatusCode(500, new ApiResponse<UserResponseDto>(
                    false,
                    "An error occurred while retrieving user"));
            }
        }

        /// <summary>
        /// Get all users
        /// </summary>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ApiResponse<IEnumerable<UserResponseDto>>>> GetAllUsers()
        {
            try
            {
                var users = await _userService.GetAllUsersAsync();

                var response = new ApiResponse<IEnumerable<UserResponseDto>>(
                    true,
                    "Users retrieved successfully",
                    users);

                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error retrieving users: {ex.Message}");
                return StatusCode(500, new ApiResponse<IEnumerable<UserResponseDto>>(
                    false,
                    "An error occurred while retrieving users"));
            }
        }

        /// <summary>
        /// Get users by role
        /// </summary>
        [HttpGet("by-role/{role}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ApiResponse<IEnumerable<UserResponseDto>>>> GetUsersByRole(
            string role)
        {
            try
            {
                var users = await _userService.GetUsersByRoleAsync(role);

                var response = new ApiResponse<IEnumerable<UserResponseDto>>(
                    true,
                    $"Users with role '{role}' retrieved successfully",
                    users);

                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error retrieving users by role: {ex.Message}");
                return StatusCode(500, new ApiResponse<IEnumerable<UserResponseDto>>(
                    false,
                    "An error occurred while retrieving users"));
            }
        }

        /// <summary>
        /// Update user
        /// </summary>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ApiResponse<UserResponseDto>>> UpdateUser(
            Guid id,
            [FromBody] UserRequestDto userDto)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToArray();

                return BadRequest(new ApiResponse<UserResponseDto>(
                    false,
                    "Validation failed",
                    errors));
            }

            try
            {
                var updatedUser = await _userService.UpdateUserAsync(id, userDto);

                var response = new ApiResponse<UserResponseDto>(
                    true,
                    "User updated successfully",
                    updatedUser);

                return Ok(response);
            }
            catch (KeyNotFoundException ex)
            {
                _logger.LogWarning($"User not found: {ex.Message}");
                return NotFound(new ApiResponse<UserResponseDto>(
                    false,
                    ex.Message));
            }
            catch (InvalidOperationException ex)
            {
                _logger.LogWarning($"Conflict while updating user: {ex.Message}");
                return Conflict(new ApiResponse<UserResponseDto>(
                    false,
                    ex.Message));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error updating user: {ex.Message}");
                return StatusCode(500, new ApiResponse<UserResponseDto>(
                    false,
                    "An error occurred while updating user"));
            }
        }

        /// <summary>
        /// Delete user
        /// </summary>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ApiResponse<object>>> DeleteUser(Guid id)
        {
            try
            {
                await _userService.DeleteUserAsync(id);

                var response = new ApiResponse<object>(
                    true,
                    "User deleted successfully",
                    null);

                return Ok(response);
            }
            catch (KeyNotFoundException ex)
            {
                _logger.LogWarning($"User not found: {ex.Message}");
                return NotFound(new ApiResponse<object>(
                    false,
                    ex.Message));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error deleting user: {ex.Message}");
                return StatusCode(500, new ApiResponse<object>(
                    false,
                    "An error occurred while deleting user"));
            }
        }

    }

}
