using Machine.Specifications;

namespace Bifrost.Specs.Events.for_UncommittedEventStream
{
    public class when_creating_a_new_uncommitted_event_stream : given.an_empty_uncommitted_event_stream
    {
        It should_have_no_events = () => event_stream.HasEvents.ShouldBeFalse();
        It should_be_an_empty_collection = () => event_stream.Count.ShouldEqual(0);
    }
}