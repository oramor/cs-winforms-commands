namespace cs_winforms_commands
{
    internal class EntityPermitChangedEventArgs : EventArgs
    {
        public EntityPermitChangedEventArgs(EntityMetadata entityMetadata)
        {
            EntityMetadata = entityMetadata;
        }

        public EntityMetadata EntityMetadata { get; init; }
    }
}
