

using DataAccessLayer.Concrete;
using TraversalCoreProje.CQRS.Queries.DestinaitonQueries;
using TraversalCoreProje.CQRS.Results.DestinationResult;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIDQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetDestinationByIDQueryResult Handle(GetDestinationByIDQuery query)
        {
            var values = _context.Destinations.Find(query.id);
            return new GetDestinationByIDQueryResult
            {
                DestinationID = values.DestinationId,
                City = values.City,
                DayNight = values.DayNight,
            };
        }
    }
}
