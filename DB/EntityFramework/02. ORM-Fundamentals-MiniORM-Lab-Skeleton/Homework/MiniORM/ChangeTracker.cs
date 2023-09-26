using System;
using System.Collections.Generic;
using System.Reflection;

namespace MiniORM
{
	internal class ChangeTracker<T>
		where T: class, new()
	{
		private readonly List<T> allEntities;
		private readonly List<T> added;
		private readonly List<T> removed;

		public ChangeTracker(IEnumerable<T> entities) 
		{
			this.added = new List<T>();
			this.removed = new List<T>();

			this.allEntities = CloneEntities(entities)
		}

		private List<T> CloneEntities(IEnumerable<T> entities)
		{
			List<T> clonedEntities = new List<T>();

			PropertyInfo[] propertiesToClone = typeof(T)
				.GetProperties()
				.Where(pi => DbContext
					.AlloewSqlTypes
					.Contains(pi.GetType()))
				.ToArray();

			foreach (T entity in entities)
			{
				T clone = Activator.CreateInstance<T>();

				foreach (PropertyInfo property in propertiesToClone)
				{
					object value = property.GetValue(entity);
					property.SetValue(clone, value);
				}

				clonedEntities.Add(clone);
			}

		}
	}

}