# Lấy tất cả thư viện của Decimal
from decimal import *

# Decimal: giới hạn số lượng con số(number)
getcontext().prec = 4;
print(Decimal(10)/Decimal(3));