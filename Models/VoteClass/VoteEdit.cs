﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.VoteClasses
{
    public class VoteEdit
    {
        public int VoteId { get; set; }

        public bool IsDeleted { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
