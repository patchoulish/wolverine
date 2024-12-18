// <auto-generated/>
#pragma warning disable
using Microsoft.Extensions.Logging;
using Wolverine.Marten.Publishing;

namespace Internal.Generated.WolverineHandlers
{
    // START: IncrementA2Handler79726078
    public class IncrementA2Handler79726078 : Wolverine.Runtime.Handlers.MessageHandler
    {
        private readonly Microsoft.Extensions.Logging.ILogger<MartenTests.SelfLetteredAggregate> _logger;
        private readonly Wolverine.Marten.Publishing.OutboxedSessionFactory _outboxedSessionFactory;

        public IncrementA2Handler79726078(Microsoft.Extensions.Logging.ILogger<MartenTests.SelfLetteredAggregate> logger, Wolverine.Marten.Publishing.OutboxedSessionFactory outboxedSessionFactory)
        {
            _logger = logger;
            _outboxedSessionFactory = outboxedSessionFactory;
        }



        public override async System.Threading.Tasks.Task HandleAsync(Wolverine.Runtime.MessageContext context, System.Threading.CancellationToken cancellation)
        {
            // The actual message body
            var incrementA2 = (MartenTests.IncrementA2)context.Envelope.Message;

            await using var documentSession = _outboxedSessionFactory.OpenSession(context);
            var eventStore = documentSession.Events;
            
            // Loading Marten aggregate
            var eventStream = await eventStore.FetchForWriting<MartenTests.SelfLetteredAggregate>(incrementA2.SelfLetteredAggregateId, cancellation).ConfigureAwait(false);

            if (eventStream.Aggregate == null) throw new Wolverine.Marten.UnknownAggregateException(typeof(MartenTests.SelfLetteredAggregate), incrementA2.SelfLetteredAggregateId);
            var selfLetteredAggregate = new MartenTests.SelfLetteredAggregate();
            
            // The actual message execution
            var outgoing1 = eventStream.Aggregate.Handle(incrementA2, _logger);

            eventStream.AppendOne(outgoing1);
            await documentSession.SaveChangesAsync(cancellation).ConfigureAwait(false);
        }

    }

    // END: IncrementA2Handler79726078
    
    
}

