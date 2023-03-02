using System;
using System.Collections.Generic;

namespace Model
{
    public class Caminhao
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Motorista { get; set; }

        public static List<Rota> Rota { get; set; } = new List<Rota>();
        public static List<Caminhao> Caminhoes { get; set; } = new List<Caminhao>();

        public Caminhao(int id, string placa, string motorista)
        {
            Id = id;
            Placa = placa;
            Motorista = motorista;
            Rota = Rota;

            Caminhoes.Add(this);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Placa: {Placa}, Motorista: {Motorista}, Rota: {Rota}";
        }

        public static void AlterarCaminhao(
            int id,
            string placa,
            string motorista
        )
        {
            Caminhao caminhao = BuscarCaminhao(id);
            caminhao.Placa = placa;
            caminhao.Motorista = motorista;
        }

        public static void ExcluirCaminhao(int id)
        {
            Caminhao caminhao = BuscarCaminhao(id);
            Caminhoes.Remove(caminhao);
        }

        public static Caminhao BuscarCaminhao(int id)
        {
            Caminhao? caminhao = Caminhoes.Find(c => c.Id == id);
            if (caminhao == null)
            {
                throw new Exception("Caminhão não encontrado");
            }

            return caminhao;
        }
    }
}