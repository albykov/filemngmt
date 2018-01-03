using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fm_test
{
    public enum TaskType { SYNC, ZIP };
    enum TaskState { NEW, IN_PROGRESS, FINISHED };

    enum NotificationLevel { APP, EMAIL, POPUP, ALL };

    class GeneralTask
    {
        private int _task_id;
        public int task_id
        {
            get { return _task_id; }
            set { _task_id = value; }
        }


        private TaskType _task_type;
        public TaskType task_type
        {
            get { return _task_type; }
            set { _task_type = value; }
        }


        public string _name { get; set; }
        private TaskState _task_state = TaskState.NEW;
        public TaskState task_state
        {
            get { return _task_state; }
            set { _task_state = value; }
        }

        private DateTime _dt_from = DateTime.UtcNow;
        public DateTime dt_from { get { return _dt_from; } }

        public bool is_folder = false;
        public NotificationLevel notification_level = NotificationLevel.APP;
        public string file_from;
        public string file_to;

        public GeneralTask execute_after;

        private int _priority = 0;
        public int priority {
            get { return _priority; }
            set { _priority = value; }
        }

    }

    enum CompressionLevel { NO_COMPRESSION, MAX };

    class ZipTaskClass : GeneralTask
    {
        public CompressionLevel compression_level = CompressionLevel.NO_COMPRESSION;
        public bool delete_after = false;

        public ZipTaskClass() {
            base.task_type = TaskType.ZIP;
        }
    }

    enum SyncDirection { SRC1toSRC2, SRC2toSRC1, BOTH, CHECK_FIRST, SPECIFIED };

    class SyncTaskClass : GeneralTask
    {
        private SyncDirection _sync_direction = SyncDirection.CHECK_FIRST;
        public SyncDirection sync_direction {
            get { return _sync_direction; }
            set { _sync_direction = value; }
        }

        public SyncTaskClass() {
            base.task_type = TaskType.SYNC;
        }
    }
}
