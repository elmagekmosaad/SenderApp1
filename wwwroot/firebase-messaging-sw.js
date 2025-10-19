importScripts('https://www.gstatic.com/firebasejs/8.10.0/firebase-app.js');
importScripts('https://www.gstatic.com/firebasejs/8.10.0/firebase-messaging.js');

const firebaseConfig = {
    ////provider
    //apiKey: "AIzaSyCm2LHKXITOB99LhN3r2zDXguXoSss1UXA",
    //authDomain: "notification-test-d2a6e.firebaseapp.com",
    //projectId: "notification-test-d2a6e",
    //storageBucket: "notification-test-d2a6e.appspot.com",
    //messagingSenderId: "266860405652",
    //appId: "1:266860405652:web:d056b8eb0f509954c42581",
    //measurementId: "G-XTMFZHS6V5"

    //mg
    apiKey: "AIzaSyA2xHwMSi8S2ZhW0bOUn7P1wTN3Opr4hr8",
    authDomain: "test-notification-94710.firebaseapp.com",
    projectId: "test-notification-94710",
    storageBucket: "test-notification-94710.firebasestorage.app",
    messagingSenderId: "1081156835593",
    appId: "1:1081156835593:web:6681d831783ce25fdedbd8",
    measurementId: "G-E6LFN9PNK1"
};

firebase.initializeApp(firebaseConfig);

const messaging = firebase.messaging();