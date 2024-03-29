// App.jsx
import React from 'react';
import { BrowserRouter, Routes, Route, Link } from "react-router-dom";
import "../mainPageContent/mainPageContent.css"
import MainPageTile from '../MainPageTile/MainPageTile';
import Gielda from '../Icons/ksiazka.jpg';
import OpinieLogo from '../Icons/stasiek.png';


export default function App() {
  
  return (
    <div className="mpc">
      <Link className="tile" to='/gielda' ><MainPageTile photo={Gielda} title="Giełda książek" /></Link>
     

     <Link to='/opinie' className='tile'>
     <MainPageTile className="tile" photo={OpinieLogo} title="Opinie o nauczycielach"/>
     </Link>
     
     
     
     <Link  to="/korepetycje" className='tile'>
     <MainPageTile className="tile" photo={OpinieLogo} title="Korepetycje"/>
     </Link>
    

    </div>
  );
}
