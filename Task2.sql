-- Т.к. используется связь "многие ко многим", то в базе должна содержаться таблица со всеми парами.
-- Предположим что она называется product_to_category. Прочие таблицы названы в этом стиле.
SELECT Product.Title, (SELECT Category.Title FROM Category AS cat WHERE Conn.CategoryId == cat.CategoryId) 
FROM Product LEFT JOIN Product_To_Category AS Conn ON Product.ProductId == Conn.ProductId;