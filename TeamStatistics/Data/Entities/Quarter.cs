﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TeamStatistics.Data.Entities
{
    public class Quarter
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; } = "";

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public virtual ICollection<Sprint> Sprints { get; set; }

        public Quarter()
        {
            Sprints = new HashSet<Sprint>();
        }
    }
}