﻿using UnityEngine;
using System.Collections.Generic;

public class Node {
	public List<Node> neighbours;
	public int x;
	public int z;
	
	public Node(){
		neighbours = new List<Node>();
	}

}
