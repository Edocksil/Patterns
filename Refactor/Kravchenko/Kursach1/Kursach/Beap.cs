using System;


namespace Kursach
{
    public class Beap
    {
        int _heapHeight;//висота купи
        int _heapSize;//кількість елементів у купі
        private int _heapCapacity;//ємнсть купи
        public int?[] Array { get; private set; }
        public Beap()
        {
            _heapHeight = 0;
            _heapCapacity = (_heapHeight) * (_heapHeight + 1) / 2;
            HeapSize = 0;
            Array = new int?[_heapCapacity];
        }

        public int HeapSize
        {
            get { return _heapSize; }
            private set
            {
                if (value > _heapCapacity) throw new ArgumentException();
                if (value == _heapCapacity) _heapCapacity++;
                _heapSize = value;//встановлюємо висоту
            }
        }
        public int Height { get { return _heapHeight; } }
        public bool Empty//перевірка, чи не порожня купа
        { get { return _heapSize == 0; } }

        public int Min()//максимальний елемент купи
        {
            return (int)(!Empty ? Array[0] : 0);
        }

        public int Max()//мінімальний елемент в купі
        {
            if (Empty) return 0;
            int max = (int)Array[_heapSize - _heapHeight - 1];
            for (int i = _heapSize - _heapHeight - 1; i < _heapSize; ++i)
            {
                if (Array[i] > max)
                {
                    max = (int)Array[i];
                }
            }
            return max;
        }

        public bool Find(int valueToSearch)//процедура пошуку. Перевірка чи наявний елемент у купі
        {
            if (Empty) return false;//немає, якщо купа порожня
            int h = _heapHeight;
            int position = h * (h + 1) / 2;//нижній лівий елемент купи. пошук починається з нього
            if (valueToSearch == Array[position]) return true;
            while (true)
            {
                if (Array[position] == null || Array[position] < valueToSearch)//відбувається просування по діагоналі
                {
                    if (position == (_heapHeight + 1) * (_heapHeight + 2) / 2 - 1)//якщо дійшли до крайього правого елемента - пошук завершено
                    {
                        return false;
                    }

                    if (position == _heapHeight * (_heapHeight + 1) / 2 - 1 &&
                        _heapSize != (_heapHeight + 1) * (_heapHeight + 2) / 2)//якщо дійшли до діагоналі - пошук завершено
                    {
                        return false;
                    }
                    if (position >= _heapSize)
                    {
                        position -= h;
                        h--;
                    }
                    else
                    {
                        if (position + h + 2 < _heapSize)
                        {
                            position += h + 2;
                            ++h;
                        }
                        else
                        {
                            ++position;
                        }
                    }
                }
                else if (Array[position] > valueToSearch)
                {
                    //рухаємось вниз і вправо
                    if (position == (h + 1) * (h + 2) / 2 - 1)
                    {
                        return false;
                    }
                    position -= h;
                    h--;
                }
                else
                {
                    return true;
                }
            }
        }

        public int Count(int valueToSearch) //пошук місцезнаходження об'єкта в масиві
        {
            /*цей пошук аналогічний до попереднього */
            if (Empty)
            {
                return 0;
            }
            int h = _heapHeight;
            int position = h * (h + 1) / 2;
            if (valueToSearch == Array[HeapSize - 1])
            {
                return HeapSize - 1;
            }
            while (true)
            {
                if (valueToSearch == Array[position])//якщо елемент знайдено - повертаємо його позицію
                    return position;
                if (Array[position] == null || valueToSearch >= Array[position])
                {
                    if (position == (_heapHeight + 1) * (_heapHeight + 2) / 2 - 1)
                    {
                        break;
                    }

                    if (position == _heapHeight * (_heapHeight + 1) / 2 - 1 && _heapSize != (_heapHeight + 1) * (_heapHeight + 2) / 2)
                    {
                        break;
                    }

                    if (position + h + 2 < _heapSize)
                    {
                        position += h + 2;
                        ++h;
                    }
                    else
                    {
                        ++position;
                        if (position >= _heapSize)
                        {
                            position -= h;
                            --h;
                        }
                    }
                }
                else if (valueToSearch < Array[position])
                {
                    if (position == (h + 1) * (h + 2) / 2 - 1)
                    {
                        break;
                    }
                    position -= h;
                    --h;
                }
            }
            return -1;//інакше - повертаємо -1
        }

        public void Insert(int valueToInsert)
        {
            if (Find(valueToInsert)) throw new Exception("Елемент відсутній");//шукаємо, чи не присутній цей елемент
            if (Empty)//якщо купа порожня вставляємо лише один елемент
            {
                Array[0] = valueToInsert;
                _heapSize = 1;
                _heapHeight = 0;
                Increase_capacity();
                return;
            }
            //оновлення розміру купи і якщо необхідно її об'єму
            int position = _heapSize;
            if (position == FirstOfRow(_heapHeight + 1))
            {
                _heapHeight++;
                if (_heapSize == _heapCapacity) Increase_capacity();//збільшуємо розмір купи
            }
            _heapSize++;
            for (int h = _heapHeight; h >= 0; --h)//для вставки всіх наступних елментів потрібно відновлювати основну властивість купи
            {
                if (position == FirstOfRow(h))//якщо елемент на позиції першого в рядку - вставка спрва
                {
                    RightPush(valueToInsert, position, h);
                    return;
                }
                if (position == LastOfRow(h))//якщо останній в рядку - всатвка зліва
                {
                    LeftPush(valueToInsert, position, h);
                    return;
                }
                // визначаємо лівого і правого батька
                int leftParent = position - h - 1;
                int rightParent = position - h;
                if (valueToInsert < Array[leftParent] && Array[leftParent] > Array[rightParent])//порівнємо елемент для вставки
                {
                    //міняємо елементи місцями
                    Array[position] = Array[leftParent];
                    Array[leftParent] = valueToInsert;
                    position = leftParent;
                }
                else if (valueToInsert < Array[rightParent])//порівнюємо з правим батьком
                {
                    Array[position] = Array[rightParent];
                    Array[rightParent] = valueToInsert;
                    position = rightParent;
                }
            }
            if (valueToInsert < Array[0])//перевіряємо чи є елемент найменшим в купі
            {
                Array[position] = Array[0];
                Array[0] = valueToInsert;
            }
            else//або просто вставляємо на останню позицію
            {
                Array[position] = valueToInsert;
            }
        }

        public void Delete(int valueToDlete)
        {
            if (!Find(valueToDlete)) return;//перевіряємо чи є елемент для видалення в масиві
            int position = Count(valueToDlete);
            //якщо купа пуста немаэ сенсу видаляти перший елемент
            if (Empty)
            {
                return;
            }
            if (_heapSize == 1)//видалення корення
            {
                _heapSize = 0;
                _heapHeight = -1;
                return;
            }
            //найменший об*єкт вважаємо коренем
            int left;
            int right;
            --_heapSize;//зменшуємо розмір
            for (int h = (int)((Math.Sqrt(2 + 8 * position) - 1) / 2); h < _heapHeight; ++h)//в циклі відбувається просування елемента до нижньої позиції
            {
                left = position + h + 1;//ліва дитина
                right = position + h + 2;//права дитина
                //далі все аналогічно до вставки
                if (
                    Array[left] < Array[right] &&
                    Array[left] < Array[_heapSize]
                    )
                {
                    Array[position] = Array[left];
                    position = left;
                }
                else if (Array[right] < Array[_heapSize])
                {
                    Array[position] = Array[right];
                    position = right;
                }
                else
                {
                    Array[position] = Array[_heapSize];
                    Array[_heapSize] = null;
                    if (_heapSize == FirstOfRow(_heapHeight))
                    {
                        decrease_capacity();
                        _heapHeight--;
                    }
                    return;
                }
            }
            // Коли доходимо до нижнього рядка можливі 3 варіант
            //   обидві дитини в купі
            //   є лише ліва дитина
            //   немає жодної дитини
            left = position + _heapHeight;
            right = left + 1;

            if (right < _heapSize)
            {
                if (
                    Array[right] < Array[left] &&
                    Array[right] < Array[_heapSize]
                    )
                {
                    Array[position] = Array[right];
                    Array[right] = Array[_heapSize];
                    Array[_heapSize] = null;
                    if (_heapSize == FirstOfRow(_heapHeight))
                    {
                        decrease_capacity();
                        _heapHeight--;
                    }
                    return;
                }
            }

            if (left < _heapSize)
            {
                if (Array[left] < Array[_heapSize - 1])
                {
                    Array[position] = Array[left];
                    Array[left] = Array[_heapSize - 1];
                    Array[_heapSize] = null;
                    if (_heapSize == FirstOfRow(_heapHeight))
                    {
                        decrease_capacity();
                        _heapHeight--;
                    }
                }
            }
            else
            {
                Array[position] = Array[_heapSize];
                Array[_heapSize] = null;
                if (_heapSize == FirstOfRow(_heapHeight))
                {
                    decrease_capacity();
                    _heapHeight--;
                }
            }
        }

        public void Clear()//видалення всієї купи
        {
            _heapHeight = 0;
            _heapCapacity = (_heapHeight) * (_heapHeight + 1) / 2;
            HeapSize = 0;
            Array = new int?[_heapCapacity];
        }
        //--------------------------------------------
        public int FirstOfRow(int height) { return (height * (height + 1)) / 2; }//перший в рядку
        public int LastOfRow(int height) { return (height + 1) * (height + 2) / 2 - 1; }//останній в рядку
        private void Increase_capacity()//збільшення об'єму
        {
            int newCapacity = (_heapHeight + 1) * (_heapHeight + 2) / 2;//об'єм нової купи
            int?[] newArray = new int?[newCapacity];//новий масив
            for (int i = 0; i < _heapSize; i++)
            {
                newArray[i] = Array[i];
            }
            Array = null;
            _heapCapacity = newCapacity;
            Array = newArray;
        }
        private void decrease_capacity()//зменшення об'єму
        {
            //процедура аналогічна до збільшення об'єму
            int newCapacity = (_heapHeight) * (_heapHeight + 1) / 2;//новий об'єм
            int?[] newArray = new int?[newCapacity];//і знову новий масив
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = Array[i];
            }
            Array = null;
            _heapCapacity = newCapacity;
            Array = newArray;
        }

        private void LeftPush(int objectToInsert, int position, int height)//вставка зліва
        {
            int parent;
            for (int h = height; h >= 0; --h)
            {
                if (position == 2)
                    parent = position - h;
                else parent = position - h - 1;
                if (objectToInsert < Array[parent])
                {
                    Array[position] = Array[parent];
                    position = parent;
                }
                else
                {
                    Array[position] = objectToInsert;
                    return;
                }
            }
            Array[position] = objectToInsert;
        }
        private void RightPush(int objectToInsert, int position, int height)//вставка справа
        {
            for (int h = height; h >= 0; --h)
            {
                int parent = position - h;

                if (objectToInsert < Array[parent])
                {
                    Array[position] = Array[parent];
                    position = parent;
                }
                else
                {
                    Array[position] = objectToInsert;
                    return;
                }
            }
            Array[position] = objectToInsert;
        }
        //----------------------------------------------
    }
}

