using System.Windows.Input;

namespace cs_winforms_commands
{
    internal class ShowEntityFormCommand : ICommand
    {
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

            MessageBox.Show("Unknown Entity");
        }

        /// <summary>
        /// Если у какой-то из сущностей изменелись права доступа, будут оповещены
        /// все компоненты, которые зависят от данной команды. Эти компоненты выполнят
        /// запрос CanExecute, передав в качестве параметра объект сущности, который
        /// будет проанализирован на предмет возможности выполнения. Проблема в том, что,
        /// похоже, все компоненты будут выполнять запрос и придется делать специализированный
        /// ICommand, чтобы запрос отправляли лишь те компоненты, которые ассоциированы
        /// с изменившейся сущностью.
        /// </summary>
        void EntityMetadata_PermitChanged(object? sender, EntityPermitChangedEventArgs e)
        {
            OnCanExecuteChanged();
        }
    }
}
