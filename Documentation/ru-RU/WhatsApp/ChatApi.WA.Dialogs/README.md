# WhatsAppApi.Dialogs
`WhatsAppApi.Dialogs` позволяет работать с чатами и группами.

### Оглавление

1.  **Операции с диалогами**
    1.  [`Получить информацию о диалоге.`](DialogOperations/GetDialog.md)
    2.  [`Получить список диалогов.`](DialogOperations/GetDialogs.md)
    3.  [`Удалить диалог.`](DialogOperations/RemoveDialog.md)

2.  **Операции с группами**
    1. [`Создание группы.`](GroupOperations/CreateGroup.md)
    2. [`Присоединение к группе (ссылка/код).`](GroupOperations/JoinGroup.md)
    3. [`Покинуть группу.`](GroupOperations/LeaveGroup.md)
    4. `Операции с участниками группы.`
        1. [`Добавление участника в группу.`](GroupOperations/ParticipantOperations/AddParticipant.md)
        2. [`Удаление участника из группы.`](GroupOperations/ParticipantOperations/RemoveParticipant.md)
        3. [`Назначение участника администратором группы.`](GroupOperations/ParticipantOperations/PromoteParticipant.md)
        4. [`Лишение участника прав администрирования группы.`](GroupOperations/ParticipantOperations/DemoteParticipant.md)

3.  **Действия пользовательского интерфейса**
    1.  [`Закрепление диалога.`](UIOperations/PinChat.md)
    2.  [`Открепление диалога.`](UIOperations/UnpinChat.md)
    3.  [`Отправление статуса "Прочитано" в диалог.`](UIOperations/ReadChat.md)
    4.  [`Отправление статуса "Не прочитано" в диалог.`](UIOperations/UnReadChat.md)
    5.  [`Отправление статуса "Печатает" в диалог.`](UIOperations/SendTypingStatus.md)
    6.  [`Отправление статуса "Записывает аудио" в диалог.`](UIOperations/SendVoiceRecordingStatus.md)

4. **Операции с WhatsApp Business**
   1.  [`Получение коллекции ярлыков.`](WhatsAppBusinessOperations/GetLabels.md)
   2.  [`Создание ярлыка.`](WhatsAppBusinessOperations/CreateLabel.md)
   3.  [`Изменение параметров ярлыка.`](WhatsAppBusinessOperations/UpdateLabel.md)
   4.  [`Удаление ярлыка.`](WhatsAppBusinessOperations/RemoveLabel.md)
   5.  [`Добавление ярлыка к диалогу.`](WhatsAppBusinessOperations/LabeledChat.md)
   6.  [`Удаление ярлыка у диалога.`](WhatsAppBusinessOperations/UnlabeledChat.md)
