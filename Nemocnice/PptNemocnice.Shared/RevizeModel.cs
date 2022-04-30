﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PptNemocnice.Shared
{
    public class RevizeModel
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public DateTime? DateTime { get; set; }
        public RevizeModel(string name, Guid id)
        {
            Name = name;
            Id = id;
        }

        public static List<RevizeModel> Vygenerovat()
        {
            List<RevizeModel> list = new List<RevizeModel>();
            for (int i = 0; i < 100; i++)
            {
                Random random = new Random();
                Guid id = Guid.NewGuid();
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                string nazev = new string(Enumerable.Repeat(chars, 5).Select(s => s[random.Next(s.Length)]).ToArray());

                RevizeModel rev = new RevizeModel(nazev, id);
                list.Add(rev);
            }
            return list;
        }
    }
}