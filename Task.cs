using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    class Task
    {
        /// <summary>
        /// Название задачи.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Дата и время завершения задачи.
        /// </summary>
        public DateTime Due { get; set; }
        /// <summary>
        /// Отметка о выполнении задачи.
        /// </summary>
        public bool Done { get; set; }

	}
}
