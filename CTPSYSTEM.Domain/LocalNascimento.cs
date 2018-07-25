using System;

namespace CTPSYSTEM.Domain
{
    public class LocalNascimento
    {
        public int Id { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public DateTime Data { get; set; }
    }
}