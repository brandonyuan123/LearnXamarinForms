using MyFirstProject.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Patterns.Repositories
{
    public interface ISQLite
    {
        SQLiteConnection GetConnectionWithCreateDatabase();
        List<Vacation> GetVacation();
        bool SaveVacation(Vacation vacation);
        bool UpdateVacation(Vacation vacation);
        void DeleteVacation(int ID);
    }   
}
