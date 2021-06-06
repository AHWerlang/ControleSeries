using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        // Atributos

        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Plataforma { get; set; }
        private int Temporada { get; set; }

        private bool Excluido {get; set; }
        
        // Métodos

        public Serie(int id, Genero genero, string titulo, string plataforma, int temporada)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Plataforma = plataforma;
            this.Temporada = temporada;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Plataforma: " + this.Plataforma + Environment.NewLine;
            retorno += "Última Temporada Assistida: " + this.Temporada + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int retornaId()
        {
            return this.Id;
        }
        public int retornaTemporada()
        {
            return this.Temporada;
        }
        public string retornaPlataforma()
        {
            return this.Plataforma;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public void Excluir() 
        {
            this.Excluido = true;
        }
    }
}