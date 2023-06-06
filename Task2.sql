-- �.�. ������������ ����� "������ �� ������", �� � ���� ������ ����������� ������� �� ����� ������.
-- ����������� ��� ��� ���������� product_to_category. ������ ������� ������� � ���� �����.
SELECT Product.Title, (SELECT Category.Title FROM Category AS cat WHERE Conn.CategoryId == cat.CategoryId) 
FROM Product LEFT JOIN Product_To_Category AS Conn ON Product.ProductId == Conn.ProductId;