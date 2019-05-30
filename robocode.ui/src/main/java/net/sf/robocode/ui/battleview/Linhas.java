package net.sf.robocode.ui.battleview;

import java.awt.Color;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.Polygon;
import java.awt.geom.Ellipse2D;
import java.awt.geom.GeneralPath;
import java.awt.geom.Rectangle2D;

import javax.swing.JComponent;

@SuppressWarnings("serial")
public class Linhas extends JComponent {

	public void paintComponent(Graphics g){
		
		Graphics2D g2 = (Graphics2D) g;

	      // draw a rectangle

	      double leftX = 100;
	      double topY = 100;
	      double width = 200;
	      double height = 150;

	      Rectangle2D rect = new Rectangle2D.Double(leftX, topY, width, height);
	      g2.setColor(new Color(0,146,62));
	      g2.fill(rect);
	      
	}

}