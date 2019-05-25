﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Manager
{
    public class BayManager : Manager, IManager
    {
        public BayManager(string btable, Database db) : base(btable, db)
        {
        }

        public override string Add(DbObject item)
        {
            Bay b = item as Bay;
            
            if (b == null)
            {
                throw new NullReferenceException("Not of type Bay");
            }

            if (_db.Create(item))
            {
                return "Successfully added bay. ID:" + item.Id;
            }

            return "Duplication! Bay already exists. ID:" + item.Id;
        }

        public override List<DbObject> RetrieveMany(string id)
        {
            List<DbObject> output = new List<DbObject>();
            List<string> idList = _db.GetIDs;
            foreach (string ids in idList)
            {
                Bay b = _db.Read(ids) as Bay;

                switch(id.ToLower())
                {
                    case "occupied":
                        if (!(b.Available)) output.Add(b);
                        break;
                    case "free":
                        if (b.Available) output.Add(b);
                        break;
                    case "all": 
                        output.Add(b); 
                        break;
                    default:
                        throw new ArgumentException("Needs to be either occupied / free or all");
                }
            }

            return output;
        }
    }
}
