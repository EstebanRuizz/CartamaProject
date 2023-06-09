﻿namespace Parque.Domain.BaseEntity
{
    public class AuditableBaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string? LastModifiedBy { get; set; }

    }
}
