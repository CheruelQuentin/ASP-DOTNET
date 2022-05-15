﻿using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace APIrestFull.Models
{
    public class DatabaseContext : DbContext
    {
        private readonly string _connectionString;
        public DatabaseContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        private MySqlConnection GetConnection()
        {
            Console.WriteLine(_connectionString);
            return new MySqlConnection(_connectionString);
        }
        public List<Conso> getConso()
        {
            List<Conso> conso = new List<Conso>();
            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from CONSO", connection);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        conso.Add(new Conso()
                        {
                            Id = reader.GetInt32("id"),
                            Name = reader.GetString("nom")
                        });
                    }
                }
            }
            return conso;
        }
        public List<Commande> getCommande()
        {
            List<Commande> commande = new List<Commande>();
            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from Commande", connection);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        commande.Add(new Commande()
                        {
                            Id = reader.GetInt32("id"),
                        });
                    }
                }
            }
            return commande;
        }

        public List<Contenir> getContenir()
        {
            List<Contenir> contenir = new List<Contenir>();
            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from contenir", connection);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        contenir.Add(new Contenir()
                        {
                            ContenirConso = reader.GetInt32("contenir_conso"),
                            ContenirCommande = reader.GetInt32("contenir_commande"),
                            Etat = reader.GetString("etat")
                        });
                    }
                }
            }
            return contenir;
        }

    }
}
