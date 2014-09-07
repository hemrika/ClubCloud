using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ClubCloud.Provider
{
    /// <summary>A collection of <see cref="T:ClubCloud.Provider.ZimbraMembershipUser" /> objects.</summary>
    [Serializable]
    public sealed class ZimbraMembershipUserCollection : ICollection, IEnumerable
    {
        private Hashtable _Indices;
        private ArrayList _Values;
        private bool _ReadOnly;
        /// <summary>Gets the membership user in the collection referenced by the specified user name.</summary>
        /// <returns>A <see cref="T:ClubCloud.Provider.ZimbraMembershipUser" /> object representing the user specified by <paramref name="name" />.</returns>
        /// <param name="name">The <see cref="P:ClubCloud.Provider.ZimbraMembershipUser.UserName" /> of the <see cref="T:ClubCloud.Provider.ZimbraMembershipUser" /> to retrieve from the collection.</param>
        public ZimbraMembershipUser this[string name]
        {
            get
            {
                object obj = this._Indices[name];
                if (obj == null || !(obj is int))
                {
                    return null;
                }
                int num = (int)obj;
                if (num >= this._Values.Count)
                {
                    return null;
                }
                return (ZimbraMembershipUser)this._Values[num];
            }
        }
        /// <summary>Gets the number of membership user objects in the collection.</summary>
        /// <returns>The number of <see cref="T:ClubCloud.Provider.ZimbraMembershipUser" /> objects in the collection.</returns>
        public int Count
        {
            get
            {
                return this._Values.Count;
            }
        }
        /// <summary>Gets a value indicating whether the membership user collection is thread safe.</summary>
        /// <returns>Always false because thread-safe membership user collections are not supported.</returns>
        public bool IsSynchronized
        {
            get
            {
                return false;
            }
        }
        /// <summary>Gets the synchronization root.</summary>
        /// <returns>Always this, because synchronization of membership user collections is not supported.</returns>
        public object SyncRoot
        {
            get
            {
                return this;
            }
        }
        /// <summary>Creates a new, empty membership user collection.</summary>
        public ZimbraMembershipUserCollection()
        {
            this._Indices = new Hashtable(10, StringComparer.CurrentCultureIgnoreCase);
            this._Values = new ArrayList();
        }
        /// <summary>Adds the specified membership user to the collection.</summary>
        /// <param name="user">A <see cref="T:ClubCloud.Provider.ZimbraMembershipUser" /> object to add to the collection.</param>
        /// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
        /// <exception cref="T:System.ArgumentNullException">The <see cref="P:ClubCloud.Provider.ZimbraMembershipUser.UserName" /> of the <paramref name="user" /> is null.</exception>
        /// <exception cref="T:System.ArgumentException">A <see cref="T:ClubCloud.Provider.ZimbraMembershipUser" /> object with the same <see cref="P:ClubCloud.Provider.ZimbraMembershipUser.UserName" /> value as <paramref name="user" /> already exists in the collection.</exception>
        public void Add(ZimbraMembershipUser user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("user");
            }
            if (this._ReadOnly)
            {
                throw new NotSupportedException();
            }
            int num = this._Values.Add(user);
            try
            {
                this._Indices.Add(user.UserName, num);
            }
            catch
            {
                this._Values.RemoveAt(num);
                throw;
            }
        }

        /// <summary>Adds the specified membership users to the collection.</summary>
        /// <param name="user">A <see cref="T:ClubCloud.Provider.ZimbraMembershipUser" /> objects to add to the collection.</param>
        /// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
        /// <exception cref="T:System.ArgumentNullException">The <see cref="P:ClubCloud.Provider.ZimbraMembershipUser.UserName" /> of the <paramref name="user" /> is null.</exception>
        /// <exception cref="T:System.ArgumentException">A <see cref="T:ClubCloud.Provider.ZimbraMembershipUser" /> object with the same <see cref="P:ClubCloud.Provider.ZimbraMembershipUser.UserName" /> value as <paramref name="user" /> already exists in the collection.</exception>
        public void Add(ZimbraMembershipUser[] users)
        {
            if (users == null)
            {
                throw new ArgumentNullException("user");
            }
            if (this._ReadOnly)
            {
                throw new NotSupportedException();
            }

            foreach (var user in users)
            {
                this.Add(user);
            }
        }

        /// <summary>Removes the membership user object with the specified user name from the collection.</summary>
        /// <param name="name">The user name of the <see cref="T:ClubCloud.Provider.ZimbraMembershipUser" /> object to remove from the collection.</param>
        /// <exception cref="T:System.NotSupportedException">The collection is read-only.</exception>
        public void Remove(string name)
        {
            if (this._ReadOnly)
            {
                throw new NotSupportedException();
            }
            object obj = this._Indices[name];
            if (obj == null || !(obj is int))
            {
                return;
            }
            int num = (int)obj;
            if (num >= this._Values.Count)
            {
                return;
            }
            this._Values.RemoveAt(num);
            this._Indices.Remove(name);
            ArrayList arrayList = new ArrayList();
            foreach (DictionaryEntry dictionaryEntry in this._Indices)
            {
                if ((int)dictionaryEntry.Value > num)
                {
                    arrayList.Add(dictionaryEntry.Key);
                }
            }
            foreach (string key in arrayList)
            {
                this._Indices[key] = (int)this._Indices[key] - 1;
            }
        }
        /// <summary>Gets an enumerator that can iterate through the membership user collection.</summary>
        /// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the entire <see cref="T:ClubCloud.Provider.ZimbraMembershipUserCollection" />.</returns>
        public IEnumerator GetEnumerator()
        {
            return this._Values.GetEnumerator();
        }
        /// <summary>Makes the contents of the membership user collection read-only.</summary>
        public void SetReadOnly()
        {
            if (this._ReadOnly)
            {
                return;
            }
            this._ReadOnly = true;
            this._Values = ArrayList.ReadOnly(this._Values);
        }
        /// <summary>Removes all membership user objects from the collection.</summary>
        public void Clear()
        {
            this._Values.Clear();
            this._Indices.Clear();
        }
        /// <summary>Copies the contents of the <see cref="T:ClubCloud.Provider.ZimbraMembershipUserCollection" /> object to an <see cref="T:System.Array" />, starting at a particular <see cref="T:System.Array" /> index.</summary>
        /// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination for the objects copied from the <see cref="T:ClubCloud.Provider.ZimbraMembershipUserCollection" /> object. The <see cref="T:System.Array" /> must have zero-based indexing. </param>
        /// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="array" /> is null.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///   <paramref name="index" /> is less than 0.</exception>
        /// <exception cref="T:System.ArgumentException">
        ///   <paramref name="array" /> is multidimensional.-or-<paramref name="index" /> is greater than or equal to the length of <paramref name="array" />.-or-The number of elements in the source <see cref="T:ClubCloud.Provider.ZimbraMembershipUserCollection" /> is greater than the available space from <paramref name="index" /> to the end of the destination array. </exception>
        /// <exception cref="T:System.InvalidCastException">The type of the source <see cref="T:ClubCloud.Provider.ZimbraMembershipUserCollection" /> cannot be cast automatically to the type of the destination array. </exception>
        void ICollection.CopyTo(Array array, int index)
        {
            this._Values.CopyTo(array, index);
        }
        /// <summary>Copies the membership user collection to a one-dimensional array.</summary>
        /// <param name="array">A one-dimensional array of type <see cref="T:ClubCloud.Provider.ZimbraMembershipUser" /> that is the destination of the elements copied from the <see cref="T:ClubCloud.Provider.ZimbraMembershipUserCollection" />. The array must have zero-based indexing.</param>
        /// <param name="index">The zero-based index in the array at which copying begins.</param>
        public void CopyTo(ZimbraMembershipUser[] array, int index)
        {
            this._Values.CopyTo(array, index);
        }
    }
}
