using Microsoft.Data.SqlClient;

class Program
{
    static string constr = "Data Source=HP;Initial Catalog=aryan;Integrated Security=True;Encrypt=False";

    static void Main(string[] args)
    {
        // commented code untouched

        while (true)
        {
            Console.WriteLine("\n--- STUDENT CRUD MENU ---");
            Console.WriteLine("1. Insert Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Update Student");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: InsertStudent(); break;
                case 2: GetAllStudents(); break;
                case 3: UpdateStudent(); break;
                case 4: DeleteStudent(); break;
                case 5: return;
            }
        }
    }

    public static void InsertStudent()
    {
        Console.Write("Enter ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        string sql = "INSERT INTO studentInfo VALUES(@id,@name)";

        using (SqlConnection con = new SqlConnection(constr))
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);

            con.Open();
            cmd.ExecuteNonQuery();
        }

        Console.WriteLine("Student inserted successfully");
    }

    static void GetAllStudents()
    {
        string sql = "select * from studentInfo";
        using (SqlConnection con = new SqlConnection(constr))
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("Id | Name");
            while (reader.Read())
            {
                Console.WriteLine(reader["id"].ToString() + "\t" + reader["name"].ToString());
            }

        }
    }
    static void UpdateStudent()
    {
        Console.WriteLine("Enter new id : ");
        int id = int.Parse((Console.ReadLine()));

        Console.WriteLine("Enter new name : ");
        string name = Console.ReadLine();

        string sql = "UPDATE studentInfo SET name=@name WHERE id=@id";

        using (SqlConnection con = new SqlConnection(constr))
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);

            con.Open();

            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                Console.WriteLine("Updated Successfully");
            }
            else
            {
                Console.WriteLine("No Student Found");
            }
        }

    }
    static void DeleteStudent()
    {
        Console.Write("Enter ID to delete: ");
        int id = int.Parse(Console.ReadLine());

        string sql = "DELETE FROM studentInfo WHERE id=@id";

        using (SqlConnection con = new SqlConnection(constr))
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0) {
                Console.WriteLine("Deleted Students Successfully");
            }
            else
            {
                Console.WriteLine("No record found");
            }
        }
    }
}
