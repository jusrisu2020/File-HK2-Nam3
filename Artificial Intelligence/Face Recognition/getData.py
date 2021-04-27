import cv2
import numpy as np
import sqlite3
import os #là module cho phép truy vào hệ thống để ta có thể lấy được các đường dẫn

def insertOrupdateDB(id, name): #tạo một hàm để có thể truy cập đến database.
	conn =  sqlite3.connect("data.db")
	''' viết câu lệnh ktra xem id khi chúng ta nhập vào thì nó đã tồn tại hay chưa.
		- nếu tồn tại rồi thì mình sẽ update.
		- ngược lại thì sẽ insert.
	'''
	query = "SELECT * FROM people WHERE ID ="+ str(id)# câu lệnh này để tới cái bảng trong sql.
	cusror = conn.execute(query) # lấy ra bản ghi từ câu lệnh query đấy
	
	isID = 0 #biến này có tác ktra xem id đã tồn tại hay chưa nếu có rồi thì cho nó bằng 1,ngược lại bằng 0
	for i in cusror: #duyệt tùng hàng trong bảng ghi.
		isID = 1
	if(isID == 0):
		query = "INSERT INTO people(ID, Name) values ("+str(id)+ ",'"+str(name)+"')"
	else:
		query = "UPDATE people SET Name='"+str(name)+"' WHERE ID= "+str(id)

	conn.execute(query)
	conn.commit()
	conn.close()

# và bây giờ chúng ta cùng chạy nhận diên và lưu nó vào torng csdl
face_cascade = cv2.CascadeClassifier(cv2.data.haarcascades+ "haarcascade_frontalface_default.xml")
cap = cv2.VideoCapture(0) # truy cập vào camera

# cho người dùng truy cập từ bàn phím 2 trường ID và name
id = input("mời bạn nhập vào id của bạn: ")
name =input("mời bạn nhập tên của bạn vào: ")

insertOrupdateDB(id, name)

index=0

while(True):
	ret , frame = cap.read()
	gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)

	#kết hợp ảnh xám của biến gray với thư viện nhận diện khuôn mặt mình trên webcam
	faces = face_cascade.detectMultiScale(gray,1.3,5)

	#vẽ hình vuông quanh khuôn mặt của chúng ta
	for (x,y,w,h) in faces:
		cv2.rectangle(frame, (x,y), (x+w, y+h), (0,0,255), 2)

		# tạo folder để cắt mặt của các ảnh mà mình vừa cắt
		# ktra xem trong đường dẫn đã có folder hay chưa
		if(not os.path.exists('dataSetimg')):
			os.makedirs('dataSetimg')# nếu chưa thì chúng ta tạo folder mới
		index = index + 1
		#lưu ảnh lại
		cv2.imwrite('dataSetimg/img.'+name+'.'+str(index)+'.jpg',gray[y: y+h,x: x+w])# trong cv2 có các câu lệnh thao tác với anh như imread() , imshow(),imwrite()
	cv2.imshow("HienAnh",frame)
	cv2.waitKey(1)
	if(index >5):
		break

cap.release()
cv2.destroyAllWindows()	
