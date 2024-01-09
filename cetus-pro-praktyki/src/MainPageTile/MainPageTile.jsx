// App.jsx
import React from 'react';
import SearchBar from '../src/Search/Search'; // Zmiana ścieżki na odpowiednią
import './App.css';
import Baner from './baner/baner';
import BottomBaner from './bottomBaner/bottomBaner';
import { BrowserRouter, Routes, Route, Link } from "react-router-dom";
import LoginPanel from '../src/loginPanel/loginPanel';
import Settings from './TwojeKonto/TwojeKonto';
import Main from './Main'
import LoginPage from './LoginPage'
import YourAccount from './YourAccount'

export default function App() {
  const handleSearch = (searchTerm) => {
    // Tutaj możesz umieścić logikę obsługi wyszukiwania
     console.log('Wyszukiwaniee:', searchTerm);
  };

  return (
    <div className="App">
      <Routes>
            <Route path='/' element={<Main/>}/>
            <Route path='/wiadomosci' />
            <Route path='/zaloguj' element={<LoginPage />} />
            <Route path='/twoje-konto' element={<YourAccount/>} />
          </Routes>
    </div>
  );
}
