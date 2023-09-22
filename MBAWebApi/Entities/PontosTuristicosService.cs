using System.Collections.Generic;

namespace MBAWebApi.Entities
{
    public static class PontosTuristicosService
    {
        public static List<string> Listar()
        {
            return new()
            {
                "Deck de Araçatiba",
                "Praça de Bambui",
                "Praia de Ponta Negra",
                "Farol de Ponta Negra",
                "Praia da Sacristia"
            };
        }
    }
}
