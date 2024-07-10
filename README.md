# Задача №1

*Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно:*

 *- Юнит-тесты*
 
 *- Легкость добавления других фигур*
 
 *- Вычисление площади фигуры без знания типа фигуры*
 
 *- Проверку на то, является ли треугольник прямоугольным"*
 
# Задача №2

*В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.*

###  Создание таблиц:
    -- продукты
    create table Products(
    id int primary key IDENTITY,
    name varchar(150) not null
    );
    
    -- категории
    create table Categories(
    id int primary key IDENTITY,
    name varchar(150) not null
    );
    
    -- таблица для отношения многие-ко-многим
    create table ProductsCategories(
    product_id int not null,
    category_id int not null,
    
    constraint PK_ProductsCategories primary key (product_id, category_id),
    
    foreign key(product_id) references Products(id) on delete cascade,
    foreign key(category_id) references Categories(id) on delete cascade
    );

###  Заполнение данных:
    insert into Products (name)
    values ('Смартфон'),('Хлеб'),('Шоколад'),('Умные часы'),('Ноутбук'),('Вода'),('Наушники'),('Диван'),('Стул'),('Подписка на сервис 3 мес.');
    
    insert into Categories(name)
    values ('Электроника'),('Продукты'),('Мебель'),('Рестораны'),('Одежда'),('Аксессуары для техники');
    
    insert into ProductsCategories(product_id, category_id)
    values (1,1), (2,2),(3,2),(4,1),(5,1),(6,2),(7,1),(8,3),(9,3),(4,6),(7,6);

### Решение задачи:
    select p.name as product, c.name as category 
    from Products p
    left join ProductsCategories pc on p.id = pc.product_id
    left join Categories c on c.id = pc.category_id;
