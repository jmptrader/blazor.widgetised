﻿namespace Blazor.Core
{
    public interface IActivatable
    {
        void Activate();

        void Deactivate();
    }

    public interface IActivatable<in TContext>
    {
        void Activate(TContext context);

        void Deactivate();
    }

}
