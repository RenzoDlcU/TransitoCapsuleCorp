
using TransitoCapsuleCorp.Models;

namespace TransitoCapsuleCorp.Services;

public class MultaService : IMultaService
{
    ApplicationDbContext context;

    public MultaService(ApplicationDbContext dbContext)
    {
        context = dbContext;
    }

    public IEnumerable<Multa> Get()
    {
        return context.Multa;
    }

    public IEnumerable<Multa> GetByMatricula(string matricula)
    {
        return context.Multa.Where(x => x.Matricula == matricula);
    }

    public async Task Save(Multa multa)
    {
        context.Add(multa);
        await context.SaveChangesAsync();
    }


}

public interface IMultaService
{
    IEnumerable<Multa> Get();
    IEnumerable<Multa> GetByMatricula(string matricula);
    Task Save(Multa creditCard);
}