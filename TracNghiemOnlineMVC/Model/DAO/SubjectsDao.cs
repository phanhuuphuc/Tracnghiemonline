﻿using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class SubjectDao
    {
        DataDbContext db = null;
        public SubjectDao()
        {
            db = new DataDbContext();
        }
        public List<Subject> ListAll()
        {
            return db.Subjects.ToList();
        }
    }
}
