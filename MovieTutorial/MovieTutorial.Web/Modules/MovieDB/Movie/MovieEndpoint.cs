
namespace MovieTutorial.MovieDB.Endpoints
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System.Data;
    using Microsoft.AspNetCore.Mvc;
    using MyRepository = Repositories.MovieRepository;
    using MyRow = Entities.MovieRow;

    [Route("Services/MovieDB/Movie/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class MovieController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyRepository().Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyRepository().Update(uow, request);
        }

        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyRepository().Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRepository().Retrieve(connection, request);
        }

        [HttpPost]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            if (request.EqualityFilter.ContainsKey("CountryId"))
            {
                var idCountry = request.EqualityFilter["CountryId"] + "";
                if (!string.IsNullOrEmpty(idCountry))
                {
                    if (idCountry == "-1")//significa que voy a buscar cuando no se selecciona un pais en el registro de movie
                    {
                        request.EqualityFilter.Remove("CountryId");
                        request.Criteria = new Criteria(MyRow.Fields.CountryId.Name).IsNull();
                    }
                }
            }
            return new MyRepository().List(connection, request);
        }
    }
}
