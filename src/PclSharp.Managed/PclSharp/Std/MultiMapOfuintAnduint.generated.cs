
// Code generated by a template
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace PclSharp.Std
{
	public static partial class Invoke
	{
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern IntPtr std_multimap_uintanduint_ctor();
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void std_multimap_uintanduint_delete(ref IntPtr ptr);

		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void std_multimap_uintanduint_begin(IntPtr ptr, IntPtr iter);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void std_multimap_uintanduint_end(IntPtr ptr, IntPtr iter);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void std_multimap_uintanduint_upperBound(IntPtr ptr, uint key, IntPtr iter);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void std_multimap_uintanduint_equal_range(IntPtr ptr, uint key, IntPtr first, IntPtr second);

		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern int std_multimap_uintanduint_size(IntPtr ptr);

		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern IntPtr std_multimap_uintanduint_iter_ctor();
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void std_multimap_uintanduint_iter_del(ref IntPtr iter);

		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void std_multimap_uintanduint_iter_assign(IntPtr ptr, IntPtr other);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern bool std_multimap_uintanduint_iter_equals(IntPtr ptr, IntPtr other);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern uint std_multimap_uintanduint_iter_first(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern uint std_multimap_uintanduint_iter_second(IntPtr ptr);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void std_multimap_uintanduint_iter_pp(IntPtr ptr);
	}

	public class MultiMapOfuintAnduint : MultiMap<uint, uint>
	{
		public int Count
			=> Invoke.std_multimap_uintanduint_size(_ptr);

		public MultiMapOfuintAnduint()
		{
			_ptr = Invoke.std_multimap_uintanduint_ctor();
		}

		public override IEnumerator<KeyValuePair<uint, uint>> GetEnumerator()
		{
			using(var begin = Begin())
			using(var end = End())
			{
				for(; !begin.Equals(end); begin.Increment())
				{
					yield return new KeyValuePair<uint, uint>(begin.Key, begin.Value);
				}
			}
		}

		public Iterator Begin()
		{
			var begin = new Iterator();
			Invoke.std_multimap_uintanduint_begin(_ptr, begin);
			return begin;
		}

		public Iterator End()
		{
			var end = new Iterator();
			Invoke.std_multimap_uintanduint_end(_ptr, end);
			return end;
		}

		public void UpperBound(uint key, Iterator it)
			=> Invoke.std_multimap_uintanduint_upperBound(_ptr, key, it);

		public IEnumerable<KeyValuePair<uint, uint>>  EqualRange(uint key)
		{
			using (var begin = new Iterator())
			using(var end = new Iterator())
			{
				Invoke.std_multimap_uintanduint_equal_range(_ptr, key, begin, end);

				for(; !begin.Equals(end); begin.Increment())
					yield return new KeyValuePair<uint, uint>(begin.Key, begin.Value);
			}
		}
		
		protected override void DisposeObject()
		{
			if (_suppressDispose)
				return;
			Invoke.std_multimap_uintanduint_delete(ref _ptr);
		}

		public class Iterator : UnmanagedObject
		{
			public Iterator()
			{
				_ptr = Invoke.std_multimap_uintanduint_iter_ctor();
			}

			public Iterator(IntPtr ptr)
			{
				_ptr = ptr;
			}

			public bool Equals(Iterator other)
				=> Invoke.std_multimap_uintanduint_iter_equals(_ptr, other);

			//makes this iterator equal to the other iterator
			public void SetTo(Iterator other)
				=> Invoke.std_multimap_uintanduint_iter_assign(_ptr, other);

			public uint Key
				=> Invoke.std_multimap_uintanduint_iter_first(_ptr);

			public uint Value
				=> Invoke.std_multimap_uintanduint_iter_second(_ptr);

			public void Increment()
				=> Invoke.std_multimap_uintanduint_iter_pp(_ptr);

			protected override void DisposeObject()
			{
				Invoke.std_multimap_uintanduint_iter_del(ref _ptr);
			}
		}
	}
}
