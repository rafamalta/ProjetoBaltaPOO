﻿namespace ProjetoBaltaPOO.ConteudoContexto
{
    public class ItemCarreira
    {
        public int Ordem { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public Curso Curso { get; set; }
    }
}
