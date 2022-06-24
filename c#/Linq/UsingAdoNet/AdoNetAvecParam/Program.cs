using System.Data.SqlClient;

int? choix = 1;
string connectionString = "Server=tfnsdotde0401b; Database = Northwind; Trusted_Connection = True;";
using (SqlConnection myConnection = new SqlConnection(connectionString))
{
    using (SqlCommand sql = myConnection.CreateCommand())
    {
        SqlDataReader myReader;
        int nombreRows;

        while (choix != 0)
        {
            Console.Write("Entrez le nom de la catégorie : ");
            string? category = Console.ReadLine();
            Console.Write("Entrez la description : ");
            string? description = Console.ReadLine();
            myConnection.Open();


            sql.CommandText = $"insert into categories(CategoryName,Description) values('{category}','{description}')";

            nombreRows = sql.ExecuteNonQuery();
            Console.WriteLine($"\n{nombreRows} ligne ajouté\n");
            sql.CommandText = "select * from categories";
            myReader = sql.ExecuteReader();
            while (myReader.Read())
            {
                var categoryID = (int)myReader[0];
                var categoryName = (string)myReader[1];
                var categoryDescription = (string)myReader[2];
                Console.WriteLine($"ID : {categoryID,-3} Name {categoryName,-15} Description : {categoryDescription,-30}");
            }
            myReader.Close();
            Console.Write("\n1 : Continuer   0 : Quitter");
            choix = int.Parse(Console.ReadLine());
            Console.Clear();
        }
        sql.CommandText = "delete from Categories where CategoryID > 8";
        nombreRows = sql.ExecuteNonQuery();
        Console.WriteLine($"\n{nombreRows} ligne supprimé");
    }
    myConnection.Close();
}