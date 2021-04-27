import cv2
import numpy as np # là một thu viện của py giúp mình thao tác với mảng nhanh hơn list trong py

face_cascade = cv2.CascadeClassifier(cv2.data.haarcascades+ "haarcascade_frontalface_default.xml")

#truy cập vào trong web cam của máy tính:
cap = cv2.VideoCapture(0) #trong opencv hổ trợ 1 hàm để trể truy cập vào trong camera của mình

while(True):
	#đầu tin thì chúng ta sẽ lấy dữ liệu từ webcam của mình
	# biến đầu tiên là biến rét nó sẽ trả về là True nếu chúng ta truy cap thành công.
	# frame  là dữ liệu mình lấy đc từ webcam của mình.
	ret , frame = cap.read() # đọc dữ liệu từ webcam.
	# để có thể train dữ liệu thì chúng ta phải chuyễn dữ liệu về ảnh sáng để chúng ta có thể train.
	gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
	#cv2.cvtColor()được sử dụng để chuyển đổi một hình ảnh từ không gian màu này sang không gian màu.
	#frame dữ liệu từ webcam
	# cv2.COLOR_BGR2GRAY là tham số để mình chuyển từ BGR sang màu gray
	'''chúng ta lấy ra đc màu xám. chúng ta kết hợp với thư viện khuôn mặt của opencv để nhận diện
	 khuôn mặt của mình trên webcam
	'''
	faces = face_cascade.detectMultiScale(gray)
	# tiếp theo chúng ta sẽ vẽ hình vuông quanh khuôn mặt mình
	for (x, y, w, h) in faces:
		#x, y là tọa độ điểmt trong hệ trục tọa độ của mình
		cv2.rectangle(frame, (x,y), (x+w, y+h), (0,0,255), 2)
		'''
			- frame là hình ảnh lấy đc từ webcam của chúng ta.
			- (x,y) là tọa độ điểm đầu tiên để vẽ lên cái hình vuông ấy.
			- (x+w, y+h) là tọa độ mà chúng ta sẽ tịnh tiến trong không gian
			- là bảng màu trong RGB [(0,0,255): là màu xanh dương]
			- 2 là độ dày của hình vuông
		'''
	cv2.imshow('NHẬN DIỆN',frame)
	if(cv2.waitKey(1) & 0xff == ord('q')):
		break
	# khi bật chương trình lên chúng ta không muốn nó bắt liền luôn
	#ord('q') sử dụng nút q để thoát khỏi chương trình.
cap.release()# giải phóng bộ nhớ
cv2.destroyAllWindows()