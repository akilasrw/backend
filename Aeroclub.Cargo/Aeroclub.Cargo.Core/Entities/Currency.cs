using Aeroclub.Cargo.Core.Entities.Core;
using System;
namespace Aeroclub.Cargo.Core.Entities
{
    public class Currency : AuditableEntity
    {
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string Symbol { get; set; } = null!;
        
    }
}
