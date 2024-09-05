using System.ComponentModel.DataAnnotations;

namespace skill_up.Models;

public class FuncionarioCurso
{

    [Key]
    public int FuncCursoId { get; set; }
    public int FuncionarioId { get; set; }
    public int CursoId { get; set; }
    public int DataValidade { get; set; }
    public virtual ApplicationUser? Funcionario { get; set; }
    public virtual Curso? Curso { get; set; }
}
