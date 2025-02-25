-------------TABLES------------
-- Kullanýcýlar Tablosu
CREATE TABLE users (
    user_id INT IDENTITY(1,1) PRIMARY KEY,
    username NVARCHAR(50) NOT NULL UNIQUE,
    password_hash NVARCHAR(255) NOT NULL,
	salary DECIMAL(10, 2) NOT NULL,
    role NVARCHAR(20) NOT NULL CHECK (role IN ('owner', 'chef', 'cashier', 'waiter')),
);

-- Menü Tablosu
CREATE TABLE menu (
    menu_id INT IDENTITY(1,1) PRIMARY KEY,
    food_name NVARCHAR(100) NOT NULL,
    price DECIMAL(10, 2) NOT NULL,
	CONSTRAINT UQ_food_name_price UNIQUE (food_name, price),
);
-- BestMenuItem içine food_name alabilmek için eklendi
ALTER TABLE menu
ADD CONSTRAINT UQ_menu_food_name UNIQUE (food_name);

-- Envanter Tablosu
CREATE TABLE inventory (
    inventory_id INT IDENTITY(1,1) PRIMARY KEY,
    inventory_name NVARCHAR(100) NOT NULL,
    stock_quantity INT NOT NULL CHECK (stock_quantity >= 0),
	inventory_unit VARCHAR(50) NOT NULL, -- e.g., kg, liter, piece
	inventory_price DECIMAL(10, 4) NOT NULL DEFAULT 0.0000
);

CREATE TABLE recipe (
    recipe_id INT IDENTITY(1,1) PRIMARY KEY,
    menu_id INT NOT NULL,
    FOREIGN KEY (menu_id) REFERENCES menu(menu_id),
);

CREATE TABLE recipe_ingredient (
    recipe_id INT NOT NULL,
    inventory_id INT NOT NULL,
    recipe_quantity DECIMAL(10, 2) NOT NULL, -- Required quantity
    recipe_unit VARCHAR(50) NOT NULL, -- e.g., kg, liter, piece
    FOREIGN KEY (recipe_id) REFERENCES recipe(recipe_id),
    FOREIGN KEY (inventory_id) REFERENCES inventory(inventory_id),
    PRIMARY KEY (recipe_id, inventory_id) -- Composite primary key
);

-- Masalar Tablosu
CREATE TABLE tables (
    table_id INT IDENTITY(1,1) PRIMARY KEY,
    table_number INT NOT NULL UNIQUE,
    is_occupied BIT DEFAULT 0, 
); 

-- Sipariþler Tablosu
CREATE TABLE orders (
    order_id INT IDENTITY(1,1) PRIMARY KEY,
    table_number INT NOT NULL,
	selected_menu_item INT NOT NULL,
    total_order_quantity DECIMAL(10, 2),
    order_status NVARCHAR(20) DEFAULT 'pending' CHECK (order_status IN ('pending', 'in progress', 'completed', 'cancelled')),
    order_date DATETIME DEFAULT GETDATE(),
	order_user_id INT NOT NULL,
    FOREIGN KEY (selected_menu_item) REFERENCES menu(menu_id),
    FOREIGN KEY (table_number) REFERENCES tables(table_number),
	FOREIGN KEY (order_user_id) REFERENCES users(user_id),
);

CREATE TABLE cash_register (
    cash_reg_id INT IDENTITY(1,1) PRIMARY KEY,
    table_number INT NOT NULL,
    transaction_date DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (table_number) REFERENCES tables(table_number),
); 
   
-- Ciro Tablosu Oluþturma
CREATE TABLE revenue (
    revenue_id INT IDENTITY(1,1) PRIMARY KEY, -- Otomatik artan ID
    total_price DECIMAL(10, 2) NOT NULL,     -- Toplam fiyat
    transaction_date DATETIME NOT NULL,       -- Ýþlem tarihi
	waiter_name NVARCHAR(20) NOT NULL,
	table_number INT NOT NULL,
	FOREIGN KEY (table_number) REFERENCES tables(table_number),
);

CREATE TABLE expense (
    expense_id INT IDENTITY(1,1) PRIMARY KEY, -- Otomatik artan ID
    total_price DECIMAL(10, 4) NOT NULL,      -- Toplam fiyat
    transaction_date DATETIME NOT NULL         -- Ýþlem tarihi
);

CREATE TABLE BestMenuItem (
    BestMenuItem_id INT IDENTITY(1,1) PRIMARY KEY, -- Otomatik artan ID
    BestMenuItem_food_name NVARCHAR(100) NOT NULL,     
    BestMenuItem_quantity INT DEFAULT 0,
	FOREIGN KEY (BestMenuItem_food_name) REFERENCES menu(food_name),
	CONSTRAINT UQ_BestMenuItem_food_name UNIQUE (BestMenuItem_food_name) -- one to one iliþki olabilmesi için eklendi
);

--------------- iNSERT KOMUTLARI--------------
INSERT INTO menu (food_name, price) VALUES 
('Margherita Pizza', 250.00),
('Pepperoni Pizza', 255.00),
('Four Cheese Pizza', 300.00),
('Vegetable Pizza', 252.00),
('Chicken Caesar Salad', 145.00),
('Mediterranean Salad', 140.00),
('Cobb Salad', 148.00),
('Quinoa Pomegranate Salad', 146.00),
('Classic Burger', 157.00),
('Cheeseburger', 158.00),
('BBQ Burger', 160.00),
('Spaghetti Napolitana', 142.00),
('Fettuccine Alfredo', 148.00),
('Penne Arrabbiata', 144.00),
('Chocolate Soufflé', 135.00),
('Tiramisu', 138.00),
('Cheesecake', 140.00),
('Profiterole', 136.00),
('Baked Rice Pudding', 90.00),
('Cola', 20.00),
('Fanta', 20.00),
('Ayran', 15.0),
('Water', 10.00),
('Orange Juice', 30.00),
('Apple Juice', 30.00),
('Peach Juice', 30.00),
('Apricot Juice', 30.00),
('Mineral Water', 15.0),
('Iced Tea', 25.0);

INSERT INTO inventory (inventory_name, stock_quantity, inventory_unit, inventory_price) VALUES
('Pizza Dough', 500, 'grams', 0.0500),
('Tomato Sauce', 500, 'grams', 0.0600),
('Mozzarella Cheese', 500, 'grams', 0.1200),
('Fresh Basil', 500, 'leaves', 0.2000),
('Parmesan Cheese', 500, 'grams', 0.2500),
('Gorgonzola Cheese', 500, 'grams', 0.3000),
('Feta Cheese', 500, 'grams', 0.1500),
('Pepperoni', 500, 'grams', 0.1800),
('Mushroom', 500, 'grams', 0.0700),
('Green Pepper', 500, 'grams', 0.0400),
('Black Olive', 500, 'grams', 0.0800),
('Red Onion', 500, 'grams', 0.0300),
('Chicken Breast', 500, 'grams', 0.0900),
('Iceberg Lettuce', 500, 'grams', 0.0250),
('Lettuce', 500, 'grams', 0.0200),
('Tomato', 500, 'grams', 0.0250),
('Cucumber', 500, 'grams', 0.0200),
('Olive Oil', 500, 'milliliters', 0.1500),
('Lemon Juice', 500, 'milliliters', 0.0500),
('Caesar Dressing', 500, 'grams', 0.1000),
('Cherry Tomato', 500, 'grams', 0.0300),
('Boiled Egg', 500, 'pieces', 7.0000),
('Corn', 500, 'grams', 0.0150),
('Avocado', 500, 'grams', 0.0700),
('Quinoa', 500, 'grams', 0.1200),
('Pomegranate Seeds', 500, 'grams', 0.0800),
('Arugula', 500, 'grams', 0.0400),
('Almond', 500, 'grams', 0.2000),
('Burger Bun', 498, 'pieces', 10.0000),
('Beef Burger Patty', 200, 'grams', 0.1200),
('Cheddar Cheese', 500, 'grams', 0.1400),
('Pickle', 496, 'grams', 0.0500),
('Caramelized Onion', 440, 'grams', 0.0400),
('Mayonnaise', 480, 'grams', 0.0300),
('Ketchup', 480, 'grams', 0.0250),
('BBQ Sauce', 440, 'grams', 0.0350),
('Spaghetti Pasta', 500, 'grams', 0.0200),
('Fettuccine Pasta', 500, 'grams', 0.0250),
('Penne Pasta', 500, 'grams', 0.0220),
('Garlic', 500, 'grams', 0.0500),
('Cream', 500, 'milliliters', 0.0600),
('Butter', 500, 'grams', 0.0800),
('Chili Paste', 500, 'grams', 0.0700),
('Parsley', 500, 'grams', 0.0150),
('Dark Chocolate', 500, 'grams', 0.1200),
('Egg', 500, 'pieces', 5.0000),
('Granulated Sugar', 500, 'grams', 0.0200),
('Flour', 500, 'grams', 0.0150),
('Ladyfinger Biscuit', 500, 'pieces', 10.0000),
('Mascarpone Cheese', 500, 'grams', 0.2000),
('Egg Yolk', 500, 'pieces', 7.5000),
('Filter Coffee', 500, 'milliliters', 0.1500),
('Cocoa Powder', 500, 'grams', 0.1000),
('Labneh Cheese', 500, 'grams', 0.0800),
('Egg Biscuit Base', 500, 'pieces', 3.8000),
('Vanilla', 500, 'packets', 0.0500),
('Cream Filling', 500, 'grams', 0.0500),
('Chocolate Sauce', 500, 'grams', 0.0700),
('Rice Flour', 500, 'grams', 0.0250),
('Milk', 500, 'milliliters', 0.0150),
('Cinnamon', 500, 'grams', 0.0900),
('Cola', 500, 'pieces', 5.0000),
('Fanta', 500, 'pieces', 5.0000),
('Ayran', 500, 'pieces', 2.5000),
('Water', 500, 'pieces', 1.0000),
('Orange Juice', 500, 'pieces', 8.0000),
('Apple Juice', 500, 'pieces', 8.0000),
('Peach Juice', 500, 'pieces', 8.0000),
('Apricot Juice', 500, 'pieces', 8.0000),
('Mineral Water', 500, 'pieces', 2.0000),
('Iced Tea', 500, 'pieces', 8.0000);

INSERT INTO recipe (menu_id) VALUES
(1),  -- Margherita Pizza
(2),  -- Pepperoni Pizza
(3),  -- Four Cheese Pizza
(4),  -- Vegetable Pizza
(5),  -- Chicken Caesar Salad
(6),  -- Mediterranean Salad
(7),  -- Cobb Salad
(8),  -- Quinoa Pomegranate Salad
(9),  -- Classic Burger
(10), -- Cheeseburger
(11), -- BBQ Burger
(12), -- Spaghetti Napolitana
(13), -- Fettuccine Alfredo
(14), -- Penne Arrabbiata
(15), -- Chocolate Soufflé
(16), -- Tiramisu
(17), -- Cheesecake
(18), -- Profiterole
(19), -- Baked Rice Pudding
(20), -- Cola
(21), -- Fanta
(22), -- Ayran
(23), -- Water
(24), -- Orange Juice
(25), -- Apple Juice
(26), -- Peach Juice
(27), -- Apricot Juice
(28), -- Mineral Water
(29); -- Iced Tea

-- Margherita Pizza
INSERT INTO recipe_ingredient (recipe_id, inventory_id, recipe_quantity, recipe_unit) VALUES
(1, 1, 200, 'grams'), 
(1, 2, 50, 'grams'), 
(1, 3, 100, 'grams'), 
(1, 4, 5, 'leaves');

-- Pepperoni Pizza
INSERT INTO recipe_ingredient VALUES
(2, 1, 1, 'piece'), 
(2, 2, 100, 'grams'), 
(2, 3, 100, 'grams'), 
(2, 8, 10, 'slices');

-- Four Cheese Pizza
INSERT INTO recipe_ingredient VALUES
(3, 1, 1, 'piece'), 
(3, 2, 100, 'grams'), 
(3, 3, 50, 'grams'), 
(3, 5, 30, 'grams'), 
(3, 6, 30, 'grams'), 
(3, 7, 30, 'grams');

-- Vegetable Pizza
INSERT INTO recipe_ingredient VALUES
(4, 1, 1, 'piece'), 
(4, 2, 100, 'grams'), 
(4, 3, 50, 'grams'),
(4, 9, 50, 'grams'),
(4, 10, 30, 'grams'),
(4, 11, 20, 'grams'),
(4, 12, 30, 'grams');

-- Chicken Caesar Salad 
INSERT INTO recipe_ingredient VALUES
(5, 13, 150, 'grams'),
(5, 14, 100, 'grams'),
(5, 5, 30, 'grams'),
(5, 20, 40, 'grams');

-- Mediterranean Salad
INSERT INTO recipe_ingredient VALUES
(6, 14, 100, 'grams'),
(6, 16, 50, 'grams'),
(6, 17, 50, 'grams'),
(6, 11, 30, 'grams'),
(6, 7, 30, 'grams'),
(6, 18, 10, 'ml'),
(6, 19, 5, 'ml');

-- Cobb Salad 
INSERT INTO recipe_ingredient VALUES
(7, 14, 100, 'grams'),
(7, 13, 100, 'grams'),
(7, 24, 50, 'grams'),
(7, 21, 50, 'grams'),
(7, 22, 1, 'piece'),
(7, 23, 30, 'grams');

-- Quinoa Pomegranate Salad 
INSERT INTO recipe_ingredient VALUES
(8, 25, 100, 'grams'),
(8, 26, 50, 'grams'),
(8, 27, 50, 'grams'),
(8, 28, 20, 'grams'),
(8, 18, 10, 'ml'),
(8, 19, 10, 'ml');

-- Classic Burger
INSERT INTO recipe_ingredient VALUES
(9, 29, 1, 'piece'),
(9, 30, 150, 'grams'),
(9, 31, 1, 'slice'),
(9, 16, 2, 'slices'),
(9, 15, 1, 'leaf'),
(9, 32, 2, 'slices'),
(9, 33, 30, 'grams'),
(9, 34, 10, 'grams'),
(9, 35, 10, 'grams');

-- Cheeseburger
INSERT INTO recipe_ingredient VALUES
(10, 29, 1, 'piece'),
(10, 30, 150, 'grams'),
(10, 31, 1, 'slice'),
(10, 16, 2, 'slices'),
(10, 32, 2, 'slices'),
(10, 33, 30, 'grams'),
(10, 34, 10, 'grams'),
(10, 35, 10, 'grams');

-- BBQ Burger
INSERT INTO recipe_ingredient VALUES
(11, 29, 1, 'piece'),
(11, 30, 150, 'grams'),
(11, 31, 1, 'slice'),
(11, 32, 2, 'slices'),
(11, 33, 30, 'grams'),
(11, 36, 30, 'grams'),
(11, 34, 10, 'grams'),
(11, 35, 10, 'grams');

-- Spaghetti Napolitana 
INSERT INTO recipe_ingredient VALUES
(12, 37, 100, 'grams'),
(12, 1, 1, 'piece'),
(12, 39, 20, 'grams'),
(12, 38, 30, 'grams');

-- Fettuccine Alfredo
INSERT INTO recipe_ingredient VALUES
(13, 38, 100, 'grams'),
(13, 37, 100, 'grams'),
(13, 39, 20, 'grams'),
(13, 16, 30, 'grams');

-- Penne Arrabbiata
INSERT INTO recipe_ingredient VALUES
(14, 40, 100, 'grams'),
(14, 41, 30, 'grams'),
(14, 39, 20, 'grams'),
(14, 16, 30, 'grams');

-- Chocolate Soufflé
INSERT INTO recipe_ingredient VALUES
(15, 42, 100, 'grams'),
(15, 16, 50, 'grams'),
(15, 43, 2, 'pieces'),
(15, 44, 100, 'grams'),
(15, 17, 30, 'grams');

-- Tiramisu
INSERT INTO recipe_ingredient VALUES
(16, 45, 200, 'grams'),
(16, 46, 3, 'pieces'),
(16, 16, 50, 'grams'),
(16, 48, 50, 'grams'),
(16, 49, 50, 'grams');

-- Cheesecake
INSERT INTO recipe_ingredient VALUES
(17, 50, 100, 'grams'),
(17, 51, 100, 'grams'),
(17, 52, 100, 'grams'),
(17, 53, 50, 'grams'),
(17, 54, 50, 'grams'),
(17, 55, 50, 'grams');

-- Profiterole
INSERT INTO recipe_ingredient VALUES
(18, 56, 200, 'grams'),
(18, 57, 100, 'grams'),
(18, 58, 100, 'grams'),
(18, 59, 50, 'grams');

-- Baked Rice Pudding
INSERT INTO recipe_ingredient VALUES
(19, 60, 100, 'grams'),
(19, 61, 50, 'grams'),
(19, 62, 30, 'grams'),
(19, 63, 30, 'grams'),
(19, 64, 10, 'grams'),
(19, 65, 10, 'grams');

--cola
INSERT INTO recipe_ingredient VALUES
(20, 62, 1, 'piece');

--fanta
INSERT INTO recipe_ingredient VALUES
(21, 63, 1, 'piece');

--ayran
INSERT INTO recipe_ingredient VALUES
(22, 64, 1, 'piece');

--water
INSERT INTO recipe_ingredient VALUES
(23, 65, 1, 'piece');

--orange juice
INSERT INTO recipe_ingredient VALUES
(24, 66, 1, 'piece');

--apple juice
INSERT INTO recipe_ingredient VALUES
(25, 67, 1, 'piece');

--peach juice
INSERT INTO recipe_ingredient VALUES
(26, 68, 1, 'piece');

--apricot juice
INSERT INTO recipe_ingredient VALUES
(27, 69, 1, 'piece');

--mineral water
INSERT INTO recipe_ingredient VALUES
(28, 70, 1, 'piece');

--iced tea
INSERT INTO recipe_ingredient VALUES
(29, 71, 1, 'piece');

--------------------- PROCEDURELER----------------

-- 1. PROCEDURE: FÝÞ ÇIKARAN PROCEDURE
GO   
CREATE PROCEDURE GetCompletedOrdersDetails (
    @TableNumber INT = NULL -- Optional, specify table number or get all tables
)
AS
BEGIN
    -- Order details for completed orders with unique TableNumber and OrderID
    WITH UniqueOrders AS (
        SELECT 
            cr.table_number AS TableNumber,
            o.order_id AS OrderID,
            m.food_name AS FoodItem,
            m.price AS PricePerItem,
            o.total_order_quantity AS QuantityOrdered,
            (m.price * o.total_order_quantity) AS TotalPrice,
            ROW_NUMBER() OVER (PARTITION BY cr.table_number, o.order_id ORDER BY o.order_id) AS RowNum
        FROM 
            cash_register cr
        INNER JOIN 
            orders o ON cr.table_number = o.table_number
        INNER JOIN 
            menu m ON o.selected_menu_item = m.menu_id
        WHERE 
            o.order_status = 'completed'
            AND (@TableNumber IS NULL OR cr.table_number = @TableNumber)
    )
    -- Filtered results for unique orders
    SELECT 
        TableNumber,
        OrderID,
        FoodItem,
        PricePerItem,
        QuantityOrdered,
        TotalPrice
    INTO #FilteredOrders -- Store results in a temporary table
    FROM 
        UniqueOrders
    WHERE 
        RowNum = 1; -- Keep only the first row for each TableNumber and OrderID

    -- Return the filtered orders
    SELECT 
        TableNumber,
        OrderID,
        FoodItem,
        PricePerItem,
        QuantityOrdered,
        TotalPrice
    FROM 
        #FilteredOrders;

    -- Calculate the total price for each table using the filtered data
    SELECT 
        TableNumber,
        SUM(TotalPrice) AS TotalTablePrice
    FROM 
        #FilteredOrders
    GROUP BY 
        TableNumber;

    -- Drop the temporary table
    DROP TABLE #FilteredOrders;
END;
GO
--EXEC GetCompletedOrdersDetails @TableNumber = 1;

--2. PROCEDURE:MASAYA KAYITLI TÜM ORDERLARI SÝLÝP, REVENUEYA CÝRO EKLEYEN, MASAYI GÜNCELLEYEN
GO
CREATE PROCEDURE ClearTable (
    @TableNumber INT
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Check if there are duplicate table_number and order_id pairs
        IF EXISTS (
            SELECT COUNT(*)
            FROM orders
            WHERE table_number = @TableNumber
            GROUP BY table_number, order_id
            HAVING COUNT(*) > 1
        )
        BEGIN
            THROW 50001, 'Duplicate table_number and order_id pairs found. Cannot proceed.', 1;
        END

        -- Calculate the total revenue for the table with only completed orders
        DECLARE @TotalRevenue DECIMAL(10, 2) = 0;
        DECLARE @WaiterName NVARCHAR(50);

        SELECT @TotalRevenue = SUM(m.price * o.total_order_quantity)
        FROM orders o
        INNER JOIN menu m ON o.selected_menu_item = m.menu_id
        WHERE o.table_number = @TableNumber
          AND o.order_status = 'completed';

        -- Fetch the waiter name associated with the table
        SELECT @WaiterName = u.username
        FROM orders o
        INNER JOIN users u ON o.order_user_id = u.user_id
        WHERE o.table_number = @TableNumber
        -- Sadece bir garson varsa, ya da ayný garsonla sipariþler varsa
        GROUP BY u.username;

        -- Insert the calculated revenue into the revenue table with waiter name and table number
        INSERT INTO revenue (total_price, transaction_date, waiter_name, table_number)
        VALUES (@TotalRevenue, GETDATE(), @WaiterName, @TableNumber);

        -- Delete associated orders for the table
        DELETE FROM orders
        WHERE table_number = @TableNumber;

        -- Delete associated cash register entries for the table
        DELETE FROM cash_register
        WHERE table_number = @TableNumber;

        -- Update the table's is_occupied status to 0
        UPDATE tables
        SET is_occupied = 0
        WHERE table_number = @TableNumber;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        -- Handle the error
        THROW;
    END CATCH;
END;
GO
--------------
--EXEC ClearTable @TableNumber = 1;


--3. PROCEDURE: MASANIN DOLU OLMASINI SAÐLAYAN 
GO
CREATE PROCEDURE UpdateTableStatus
    @TableNumber INT -- Masa numarasýný parametre olarak alýr
AS
BEGIN
    -- Hata kontrolü: Geçerli bir masa numarasý var mý?
    IF NOT EXISTS (SELECT 1 FROM tables WHERE table_number = @TableNumber)
    BEGIN
        PRINT 'Error: Table number does not exist.';
        RETURN;
    END

    -- Masa dolu olarak güncelleniyor
    UPDATE tables
    SET is_occupied = 1
    WHERE table_number = @TableNumber;

    PRINT 'Table status updated successfully: Table is now occupied.';
END;
GO
------------
--EXEC UpdateTableStatus @TableNumber = 3;

--4. PROCEDURE: CASH REGÝSTERE TABLO EKLEM-- 
GO
CREATE PROCEDURE AddCashRegisterEntry (
    @TableNumber INT
)
AS
BEGIN
    INSERT INTO cash_register (table_number)
    VALUES (@TableNumber);
END;
GO

--5. PROCEDURE: BEST MENÜ ÝTEM EKLEME--
GO
CREATE PROCEDURE UpdateBestMenuItem
    @selected_menu_item INT, -- Menüde seçilen yemeðin menu_id'si
    @total_order_quantity INT -- Sipariþ edilen miktar
AS
BEGIN
    -- Menüden yemeðin adýný al
    DECLARE @food_name NVARCHAR(100);
    SELECT @food_name = food_name FROM menu WHERE menu_id = @selected_menu_item;

    -- Eðer BestMenuItem tablosunda bu yemek varsa
    IF EXISTS (SELECT 1 FROM BestMenuItem WHERE BestMenuItem_food_name = @food_name)
    BEGIN
        -- Mevcut miktarý güncelle
        UPDATE BestMenuItem
        SET BestMenuItem_quantity = BestMenuItem_quantity + @total_order_quantity
        WHERE BestMenuItem_food_name = @food_name;
    END
    ELSE
    BEGIN
        -- Yeni yemek ekle
        INSERT INTO BestMenuItem (BestMenuItem_food_name, BestMenuItem_quantity)
        VALUES (@food_name, @total_order_quantity);
    END
END;
GO

----------------TRÝGGER---------
--1. TRÝGGER: ENVANTER GÜNCELLEME
GO
CREATE TRIGGER trg_UpdateInventory
ON orders
AFTER UPDATE
AS
BEGIN
    -- Eðer order_status 'in progress' ise stok güncelleme iþlemi yap
    IF EXISTS (SELECT * FROM inserted WHERE order_status = 'in progress')
    BEGIN
        UPDATE i
        SET stock_quantity = stock_quantity - (ri.recipe_quantity * ins.total_order_quantity)
        FROM inventory i
        INNER JOIN recipe_ingredient ri ON ri.inventory_id = i.inventory_id
        INNER JOIN recipe r ON r.recipe_id = ri.recipe_id
        INNER JOIN inserted ins ON r.menu_id = ins.selected_menu_item
        WHERE (i.stock_quantity - (ri.recipe_quantity * ins.total_order_quantity)) >= 0; -- Stok yeterli mi kontrolü
    END
END;
GO
--UPDATE orders
--SET order_status = 'in progress'
--WHERE order_id = 1; -- Örnek bir order_id

--2. TRÝGGER: CANCEL EDÝLEN ORDERI SÝLME
GO
CREATE TRIGGER trg_DeleteCanceledOrder
ON orders
AFTER UPDATE
AS
BEGIN
    -- Sipariþ durumu 'canceled' olarak güncellenen kayýtlarý sil
    DELETE FROM orders
    WHERE order_id IN (
        SELECT inserted.order_id
        FROM inserted
        WHERE inserted.order_status = 'cancelled'
    );
END;
GO

--UPDATE orders 
--SET order_status = 'cancelled' 
--WHERE order_id = 4;

-- 3.TRIGGER: GÝDER TABLOSUNA DEÐER EKLEME
GO
CREATE TRIGGER trg_update_inventory
ON inventory
AFTER UPDATE
AS
BEGIN
    DECLARE @total_price DECIMAL(10, 4);
    DECLARE @transaction_date DATETIME;
    
    -- Ýþlem tarihi olarak þu anki tarihi al
    SET @transaction_date = GETDATE();

    -- Yeni envanter kaydýnýn toplam maliyetini hesapla
    SELECT @total_price = i.stock_quantity * i.inventory_price
    FROM inserted i;

    -- Sadece yeni eklenen miktarý alýn ve toplam maliyeti hesaplayýn
    DECLARE @new_stock_quantity INT;
    DECLARE @old_stock_quantity INT;

    SELECT @new_stock_quantity = i.stock_quantity
    FROM inserted i;

    SELECT @old_stock_quantity = d.stock_quantity
    FROM deleted d;

    -- Sadece yeni eklenen miktarý hesaplayýn
    DECLARE @added_quantity INT = @new_stock_quantity - @old_stock_quantity;

    -- Hesaplanan toplam maliyeti expense tablosuna ekle
    IF @added_quantity > 0
    BEGIN
        INSERT INTO expense (total_price, transaction_date)
        VALUES (@added_quantity * (SELECT inventory_price FROM inserted), @transaction_date);
    END
END;
GO


-----------WIEV--------
--1. WIEV: Available Menu Items
CREATE VIEW AvailableMenuItems AS
SELECT m.menu_id, m.food_name, m.price
FROM menu m
WHERE NOT EXISTS (
    SELECT 1
    FROM recipe_ingredient ri
    INNER JOIN inventory i ON ri.inventory_id = i.inventory_id
    WHERE ri.recipe_id = (SELECT recipe_id FROM recipe WHERE menu_id = m.menu_id)
      AND i.stock_quantity < ri.recipe_quantity
);


----------DENEME EKLEME KOMUTLARI------
INSERT INTO tables (table_number, is_occupied)
VALUES 
(1, 0),
(2, 0),
(3, 0),
(4, 0),
(5, 0),
(6, 0),
(7, 0),
(8, 0),
(9, 0),
(10, 0),
(11, 0),
(12, 0);

INSERT INTO users (username, password_hash, role, salary) 
VALUES 
('owner1', 'password1', 'owner','20000'),
('chef1', 'password2', 'chef','20000'),
('cashier1', 'password3', 'cashier','20000'),
('waiter1', 'password4', 'waiter','20000');