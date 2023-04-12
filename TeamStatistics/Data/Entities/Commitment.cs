﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamStatistics.Data.Entities
{
    public class Commitment
    {
        [Key]
        public Guid Id { get; set; }

        public bool DidComplete { get; set; }

        public bool IncludeInData { get; set; }

        public bool WasInitiallyCommitted { get; set; }

        public DateTime DateCreatedUtc { get; set; }

        public DateTime DateModifiedUtc { get; set; }

        public string TimeZone { get; set; } = "";


        #region Relationships

        public Guid SprintId { get; set; }

        public virtual Sprint Sprint { get; set; }

        public Guid JiraIssueId { get; set; }

        public virtual JiraIssue JiraIssue { get; set; }

        public Guid DeveloperId { get; set; }

        public virtual Developer Developer { get; set; }

        #endregion
    }
}
