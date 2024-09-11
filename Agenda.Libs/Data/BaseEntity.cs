namespace Agenda.Libs.Data;

public abstract class BaseEntity
{
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
}