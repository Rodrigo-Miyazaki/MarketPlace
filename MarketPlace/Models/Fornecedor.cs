﻿namespace MarketPlace.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public string CNPJ { get; set; }
    }
}
