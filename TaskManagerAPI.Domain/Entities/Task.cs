using System.ComponentModel.DataAnnotations;
using TaskManagerAPI.Domain.Common;

namespace TaskManagerAPI.Domain.Task;
public class Task
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "O campo Nome é obrigatório")]
    public string Name { get; set; } = string.Empty;
    [Required(ErrorMessage = "O campo Descrição é obrigatório")]
    public string Description { get; set; } = string.Empty;
    [Required(ErrorMessage = "O campo Prioridade é obrigatório")]
    public Priority Priotity { get; set; }
    [Required(ErrorMessage = "O campo Deadline é obrigatório")]
    public DateTime Deadline { get; set; }
    [Required(ErrorMessage = "O campo Status é obrigatório")]
    public Status Status { get; set; }
}
