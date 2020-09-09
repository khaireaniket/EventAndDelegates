# EventAndDelegates

This solution is written in .Net Core as a .Net Standard Library. Solution consists of 3 projects.

- UsingCustomDelegateAndNoEventArgs
> Uses custom delegate to handle events with no event arguments (This is older way of writing events and not recommended anymore, but gives a good understanding how built in delegates work.

- UsingCustomDelegateAndEventArgs
> Uses custom delegate to handle events using a couple of event arguments (This is also older way of writing events and not recommended anymore)

- UsingInBuildDelegateEventHandlerAndEventArgs
> Uses in built delegate called `EventHandler` to handle events using a couple of event arguments (This is a recommended practice of writing modern event handlers)
