<!-- Option 1: jQuery and Bootstrap Bundle (includes Popper) -->
<script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.bundle.min.js"></script>

<!-- The core Firebase JS SDK is always required and must be listed first -->
<script src="https://www.gstatic.com/firebasejs/8.3.1/firebase-app.js"></script>

<!-- Firestore -->
<script src="https://www.gstatic.com/firebasejs/8.3.1/firebase-firestore.js"></script>

<!-- TODO: Add SDKs for Firebase products that you want to use https://firebase.google.com/docs/web/setup#available-libraries -->
<script src="https://www.gstatic.com/firebasejs/8.3.1/firebase-analytics.js"></script>

<script>
	// Your web app's Firebase configuration
	// For Firebase JS SDK v7.20.0 and later, measurementId is optional
	var firebaseConfig = {
		apiKey: "AIzaSyDCJVkq1jyu-adJEWMq44IarLZyE2IETs0",
		 authDomain: "agumap-phanhoangtrung.firebaseapp.com",
		 projectId: "agumap-phanhoangtrung",
		 storageBucket: "agumap-phanhoangtrung.appspot.com",
		 messagingSenderId: "747361096455",
		 appId: "1:747361096455:web:5e85bdb9677ade7384aba2",
		 measurementId: "G-EGNVPSK4HD"
	};
	// Initialize Firebase
	firebase.initializeApp(firebaseConfig);
	firebase.analytics();
	var db = firebase.firestore();
</script>