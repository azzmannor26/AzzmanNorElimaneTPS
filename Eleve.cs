using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    internal class Eleve
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string groupe { get; set; }
        private Database db;

        public Eleve(int id, string nom, string prenom, string groupe) {

            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.groupe = groupe;
            db = new Database();
        }
        public void ajouterEtudiant(Eleve E)
        {
            if (E == null)
            {
                Console.WriteLine("Erreur : L'élève est null !");
                return;
            }

            try
            {
                // Connection à la base de données
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    // Requête SQL d'insertion
                    string query = "INSERT INTO Eleves (nom, prenom, groupe) VALUES (@nom, @prenom, @groupe)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nom", E.nom);
                        cmd.Parameters.AddWithValue("@prenom", E.prenom);
                        cmd.Parameters.AddWithValue("@groupe", E.groupe);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("L'élève a été ajouté avec succès !");
                        }
                        else
                        {
                            Console.WriteLine("Erreur : Aucun élève ajouté.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
            }
        }


        public void updateEtudiant(Eleve E)
        {
            if (E == null)
            {
                Console.WriteLine("Erreur : L'élève est null !");
                return;
            }

            try
            {
                // Connexion à la base de données
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    // Requête SQL de mise à jour
                    string query = "UPDATE Eleves SET nom = @nom, prenom = @prenom, groupe = @groupe WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Ajouter les paramètres
                        cmd.Parameters.AddWithValue("@nom", E.nom);
                        cmd.Parameters.AddWithValue("@prenom", E.prenom);
                        cmd.Parameters.AddWithValue("@groupe", E.groupe);
                        cmd.Parameters.AddWithValue("@id", E.id);  // Fix: Add the ID for WHERE condition

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("L'élève a été mis à jour avec succès !");
                        }
                        else
                        {
                            Console.WriteLine("Erreur : Aucun élève mis à jour.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
            }
        }


        public void deleteEtudiant(int id)
        {
            try
            {
                // Connexion à la base de données
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    // Requête SQL de suppression
                    string query = "DELETE FROM Eleves WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                     

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("L'élève a été supprimé avec succès !");
                        }
                        else
                        {
                            Console.WriteLine("Erreur : Aucun élève trouvé avec cet ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
            }
        }



        public Eleve Rechercher(int id)
        {
            Eleve eleveTrouve = null;

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    // Requête SQL pour rechercher un élève par ID
                    string query = "SELECT * FROM Eleves WHERE ID = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Si un résultat est trouvé
                            {
                                int idEleve = reader.GetInt32("ID");
                                string nom = reader.GetString("Nom");
                                string prenom = reader.GetString("Prenom");
                                string groupe = reader.GetString("Groupe");

                                // Créer un objet Eleve avec les données trouvées
                                eleveTrouve = new Eleve(idEleve, nom, prenom, groupe);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
            }

            return eleveTrouve; // Retourne l'élève trouvé ou null
        }


        public override string ToString()
        {
            return base.ToString();
        }


        public List<Eleve> Lister()
        {
            List<Eleve> listeEleves = new List<Eleve>(); // Initialize the list

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    // Requête SQL pour récupérer tous les élèves
                    string query = "SELECT * FROM Eleves";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read()) // 🔥 Loop through all rows
                            {
                                int idEleve = reader.GetInt32("ID");
                                string nom = reader.GetString("Nom");
                                string prenom = reader.GetString("Prenom");
                                string groupe = reader.GetString("Groupe");

                                // Ajouter chaque élève à la liste
                                listeEleves.Add(new Eleve(idEleve, nom, prenom, groupe));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
            }

            return listeEleves; // Retourne la liste complète des élèves
        }



    }
}
