import React, { Component } from 'react'
import {MainContextConsumer} from '../MainContext/MainContext'
import MuttonSnacks from './MuttonSnacks'
import {Link} from 'react-router-dom'

export default class MuttonSnacksList extends Component {
    render() {
        return (
            <>
                <h2 style={{textTransform:"uppercase"}}>7 Hills Mutton Snacks Section</h2>
                <Link to="./">
            <button className="btn" style={{position:"fixed",left:"6rem",backgroundColor:"orange",width:"9rem",top:"0.4rem"}}>Home</button>
            </Link>
            <Link to="./Cart">
            <button className="btn" style={{position:"fixed",left:"65rem",backgroundColor:"orange",width:"9rem",top:"0.4rem"}}>Go to Cart</button>
            </Link>
                <MainContextConsumer>
                    {
                        value=>{
                            // console.log(value)
                            return value.muttonSnacksProducts.map((item,index)=>{
                                return <MuttonSnacks key={index} item={item}></MuttonSnacks>
                            })
                        }
                    }
                </MainContextConsumer>
            </>
        )
    }
}
