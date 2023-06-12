using System.Windows.Input;

namespace cs_winforms_commands
{
    /// <summary>
    /// Класс, реализовавший этот интерфейс, способен оповещать объект
    /// команды об изменении статуса доступности команды. В свою очередь, объект
    /// команды, подписавшийся на эти оповещения, будет генерировать событие
    /// <see cref="ICommand.CanExecuteChanged"/> для оповещения компонентов,
    /// которым назначена эта команда.
    /// </summary>
    internal interface ICommandAvailableNotify
    {
        event EventHandler<EntityPermitChangedEventArgs>? CommandAvailableChanged;
    }
}
