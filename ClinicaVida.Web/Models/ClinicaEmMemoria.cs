
namespace ClinicaVida.Web.Models;

public static class ClinicaEmMemoria
{
    public static List<Especialidade> Especialidades { get; } = new()
    {
        new Especialidade
        {
            Id = 1,
            Nome = "Cardiologia",
            Descricao = "Coração e vasos"
        },
        new Especialidade
        {
            Id = 2,
            Nome = "Pediatria",
            Descricao = "Saúde das crianças"
        },
        new Especialidade
        {
            Id = 3,
            Nome = "Dermatologia",
            Descricao = "Cuidados com a pele"
        },
        new Especialidade
        {
            Id = 4,
            Nome = "Ortopedia",
            Descricao = "Ossos e articulações"
        }
    };

    public static List<Medico> Medicos { get; } = new()
    {
        new Medico
        {
            Id = 1,
            Nome = "Dra. Marta Lisboa",
            Crm = "55307",
            EspecialidadeId = 1
        },
        new Medico
        {
            Id = 2,
            Nome = "Dr. Carlos Almeida",
            Crm = "55308",
            EspecialidadeId = 1
        },
        new Medico
        {
            Id = 3,
            Nome = "Dra. Ana Paula",
            Crm = "55309",
            EspecialidadeId = 2
        },
        new Medico
        {
            Id = 4,
            Nome = "Dr. Pedro Santos",
            Crm = "55310",
            EspecialidadeId = 2
        },
        new Medico
        {
            Id = 5,
            Nome = "Dra. Juliana Costa",
            Crm = "55311",
            EspecialidadeId = 3
        },
        new Medico
        {
            Id = 6,
            Nome = "Dr. Ricardo Oliveira",
            Crm = "55312",
            EspecialidadeId = 4
        }
    };
}
