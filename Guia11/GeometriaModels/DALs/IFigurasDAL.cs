using GeometriaModels.Models;

namespace GeometriaModels.DALs;

public interface IFigurasDAL
{
    List<FiguraModel> GetAll();
    FiguraModel GetById(int id);
    FiguraModel Add(FiguraModel figura);
    FiguraModel Save(FiguraModel entidad);
    void Delete(int id);
}
