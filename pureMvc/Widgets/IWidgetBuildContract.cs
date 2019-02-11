﻿using Blazor.PureMvc.Messaging;

namespace Blazor.PureMvc.Widgets
{
    public interface IWidgetBuildContract
    {
        void SetPresenter(IWidgetPresenter presenter);

        void SetCustomisation(object constomisation);

        void SetState(object state);

        void SetMessageBus(IMessageBus bus);
    }
}