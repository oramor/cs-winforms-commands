using System.Windows.Input;

namespace cs_winforms_commands
{
    internal class ShowEntityFormCommand : ICommand
    {
        public ShowEntityFormCommand()
        {
            /// Команды, которые зависят от изменения прав доступа сущности,
            /// должны подписаться на статическое событие, которое генерируется
            /// любым экземпляром при изменении прав
            EntityMetadata.EntityPermitChanged += EntityMetadata_EntityPermitChanged;
        }

        public event EventHandler? CanExecuteChanged;
        void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        public bool CanExecute(object? parameter)
        {
            if (parameter is EntityMetadata entity)
            {
                return entity.IsShowAvailable;
            }

            return false;
        }

        public void Execute(object? parameter)
        {
            if (parameter is EntityMetadata entity)
            {
                MessageBox.Show($"Entity: {entity.DataDomainName}");
            }
            else
            {
                MessageBox.Show("Unknown Entity");
            }
        }

        /// <summary>
        /// Если у какой-то из сущностей изменелись права доступа, будут оповещены
        /// все компоненты, которые зависят от данной команды. Эти компоненты выполнят
        /// запрос CanExecute, передав в качестве параметра объект сущности, который
        /// будет проанализирован на предмет возможности выполнения. Проблема в том,
        /// запрос выполнят вообще все компоненты, в которые передан объект данной
        /// команды. Тут можно создать декоратор компонента и переопределить свойство
        /// Command, используя new, чтобы самостоятельно выполнять подписку на событие
        /// CanExecuteChanged, но в этом событии нет информации об объекте сущности,
        /// чтобы можно было сопоставить ее с объектом из CommandParameter (и вызывать
        /// <see cref="ICommand.CanExecute(object?)"/> лишь в том случае, когда
        /// объекты совпадают.
        /// 
        /// Но вообще-то можно передать нужный EventArgs так CanExecuteChanged?.Invoke(this,
        /// new EntityPermitChangedEventArgs(new EntityMetadata("dfdf")));
        /// </summary>
        void EntityMetadata_EntityPermitChanged(object? sender, EntityPermitChangedEventArgs e)
        {
            OnCanExecuteChanged();
        }
    }
}
