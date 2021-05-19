# chen cac package
import pandas as pd
import numpy as np
import os

from sklearn.model_selection import train_test_split
from sklearn.metrics import accuracy_score, classification_report

# load du lieu
# load dataset from csv file 
data = pd.read_csv('./Data/breast-cancer-wisconsin.data') 
data.head()

from sklearn import preprocessing
le = preprocessing.LabelEncoder()
for column_name in data.columns:
	if data[column_name].dtype == object:
		data[column_name] = le.fit_transform(data[column_name])
	else:
		pass

# tach nhan tap du lieu
y = data.iloc[: , -1]
X = data.iloc[ : ,1:11]

X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.3)
print("Training size: %d" % len(y_train))
print("Test size    : %d" % len(y_test))

from sklearn.naive_bayes import GaussianNB 
gnb = GaussianNB()

gnb.fit(X_train, y_train)

y_pred = gnb.predict(X_test)

print("Print results for 2 test data points:")
print("Predicted labels: ", y_pred[15:35])
print("Ground truth    : ", y_test[15:35])

print("Accuracy of Decision tree: %.2f %%" % ( 100 * accuracy_score(y_test, y_pred)))
print('Classification Report:\n{}\n'.format(classification_report(y_test,gnb.predict(X_test))))
