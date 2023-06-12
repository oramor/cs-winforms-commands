namespace cs_winforms_commands
{
    internal class EntityMetadata : IHavePermits
    {
        bool _isShowAvailable = false;

        public EntityMetadata(string dataDomainName)
        {
            DataDomainName = dataDomainName;
        }

        /// <summary>
        /// Статическое событие позволяет всем командам, доступность которых зависит от статуса
        /// сущности подписаться на оповещение об изменении прав один раз и не отслеживать
        /// создание объектов сущности. Но поскольку событие статическое, придется внимательно
        /// следить за отписками.
        /// </summary>
        public static event EventHandler<EntityPermitChangedEventArgs>? EntityPermitChanged;
        void OnEntityPermitChanged(EntityPermitChangedEventArgs e)
        {
            EntityPermitChanged?.Invoke(this, e);
        }

        public string DataDomainName { get; init; }
        public bool IsShowAvailable
        {
            get => _isShowAvailable;
            set {
                if (_isShowAvailable == value)
                    return;

                _isShowAvailable = value;

                OnEntityPermitChanged(new EntityPermitChangedEventArgs(this));
            }
        }
    }
}
