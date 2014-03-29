package capaPresentacion;
import java.awt.Component;
import java.awt.Dimension;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.ArrayList;
import java.util.TreeMap;

import javax.swing.DefaultComboBoxModel;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JList;
import javax.swing.JOptionPane;
import javax.swing.JProgressBar;
import javax.swing.JScrollPane;
import javax.swing.JTextField;
import javax.swing.ListModel;

import javax.swing.WindowConstants;
import javax.swing.SwingUtilities;

import capaLogica.Administrador;
import capaLogica.Gestor;
import capaLogica.MultiAdministrador;


/**
* This code was edited or generated using CloudGarden's Jigloo
* SWT/Swing GUI Builder, which is free for non-commercial
* use. If Jigloo is being used commercially (ie, by a corporation,
* company or business for any purpose whatever) then you
* should purchase a license for each developer using Jigloo.
* Please visit www.cloudgarden.com for details.
* Use of Jigloo implies acceptance of these licensing terms.
* A COMMERCIAL LICENSE HAS NOT BEEN PURCHASED FOR
* THIS MACHINE, SO JIGLOO OR THIS CODE CANNOT BE USED
* LEGALLY FOR ANY CORPORATE OR COMMERCIAL PURPOSE.
*/
public class PantallaModificarAbogado extends javax.swing.JFrame {
	private JTextField txtBusqueda;
	private JButton btnBuscar;
    private Gestor gestor;
    private JTextField txtNumIdentificacion;
    private JButton btnRegresar;
    private JButton btnModificar;
    private JLabel busqueda;
    private JTextField txtNumColegiado;
    private JLabel numColegiado;
    private JLabel numIdentificacion;
    private JTextField txtNomAbogado;
    private JLabel nomAbogado;

	public static void main(String[] args) {
		SwingUtilities.invokeLater(new Runnable() {
			public void run() {
				PantallaModificarAbogado inst = new PantallaModificarAbogado();
				inst.setLocationRelativeTo(null);
				inst.setVisible(true);
			}
		});
	}
	
	public PantallaModificarAbogado() {
		super();
		initGUI();
		gestor=new Gestor();
	}
	
	private void initGUI() {
		try {
			setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE);
			getContentPane().setLayout(null);
			getContentPane().setBackground(new java.awt.Color(0,128,255));
			this.setTitle("Modificar Administrador");
			this.setIconImage(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/abo.jpg")).getImage());
			{
				txtBusqueda = new JTextField();
				getContentPane().add(txtBusqueda);
				txtBusqueda.setBounds(18, 59, 275, 23);
			}
			{
				btnBuscar = new JButton();
				getContentPane().add(btnBuscar);
				btnBuscar.setText("Buscar");
				btnBuscar.setBounds(329, 54, 122, 33);
				btnBuscar.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/bus1.gif")));
				btnBuscar.setBackground(new java.awt.Color(255,255,255));
				btnBuscar.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnBuscar.actionPerformed, event="+evt);
						//TODO add your code for btnBuscar.actionPerformed
						btnBuscar_actionPerformed(evt);
					}


				});
			}
			{
				nomAbogado = new JLabel();
				getContentPane().add(nomAbogado);
				nomAbogado.setText("Nombre Administrador");
				nomAbogado.setBounds(18, 101, 155, 20);
			}
			{
				txtNomAbogado = new JTextField();
				getContentPane().add(txtNomAbogado);
				txtNomAbogado.setBounds(173, 100, 278, 23);
			}
			{
				numIdentificacion = new JLabel();
				getContentPane().add(numIdentificacion);
				numIdentificacion.setText("Numero de Identificacion");
				numIdentificacion.setBounds(18, 143, 161, 19);
			}
			{
				txtNumIdentificacion = new JTextField();
				getContentPane().add(txtNumIdentificacion);
				txtNumIdentificacion.setEditable(false);
				txtNumIdentificacion.setBounds(191, 141, 117, 23);
			}
			{
				numColegiado = new JLabel();
				getContentPane().add(numColegiado);
				numColegiado.setText("Numero Colegiado");
				numColegiado.setBounds(18, 183, 137, 16);
			}
			{
				txtNumColegiado = new JTextField();
				getContentPane().add(txtNumColegiado);
				txtNumColegiado.setBounds(191, 180, 117, 23);
			}
			{
				busqueda = new JLabel();
				getContentPane().add(busqueda);
				busqueda.setText("Busqueda por Numero Identificación Administrador");
				busqueda.setBounds(22, 15, 342, 27);
				busqueda.setFont(new java.awt.Font("Andalus",0,14));
			}
			{
				btnModificar = new JButton();
				getContentPane().add(btnModificar);
				btnModificar.setText("Modificar");
				btnModificar.setBounds(18, 221, 173, 44);
				btnModificar.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/modificar.gif")));
				btnModificar.setBackground(new java.awt.Color(255,255,255));
				btnModificar.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnModificar.actionPerformed, event="+evt);
						//TODO add your code for 
						btnModificar_actionPerformed(evt);
					}

				});
			}
			{
				btnRegresar = new JButton();
				getContentPane().add(btnRegresar);
				btnRegresar.setText("Regresar");
				btnRegresar.setBounds(278, 221, 173, 44);
				btnRegresar.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/salir.gif")));
				btnRegresar.setBackground(new java.awt.Color(255,255,255));
				btnRegresar.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnRegresar.actionPerformed, event="+evt);
						//TODO add your code for btnRegresar.actionPerformed
						btnRegresar_actionPerformed(evt);
					}


				});
			}

			pack();
			this.setSize(502, 329);
		} catch (Exception e) {
		    //add your error handling code here
			e.printStackTrace();
		}
	}

	private void btnBuscar_actionPerformed(ActionEvent evt) {
		
		String numIdentificacion;
		numIdentificacion=txtBusqueda.getText();
		Administrador administrador;
		try {
			administrador=gestor.buscarAdministrador(numIdentificacion);
			txtNomAbogado.setText(administrador.getNomAdministrador()+"");
			txtNumIdentificacion.setText(administrador.getNumIdentAdministrador()+"");
			txtNumColegiado.setText(administrador.getNumColegiado()+"");
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			txtNumIdentificacion.setText("");
			txtNumColegiado.setText("");
			txtNomAbogado.setText("No se encontro el Abogado Buscado");
		}	
	}
	private void btnModificar_actionPerformed(ActionEvent evt) {
		String numIdentificacion,nomAbogado,numColegiado,mjs;
		numIdentificacion=txtNumIdentificacion.getText();
		nomAbogado=txtNomAbogado.getText();
		numColegiado=txtNumColegiado.getText();
		//txtNomAbogado.setText("No   " +numIdentificacion+nomAbogado+numColegiado);
		if(!numIdentificacion.equals(null)&&!nomAbogado.equals(null)&&!numColegiado.equals(true)){
			mjs=gestor.modificarAdministrador(numIdentificacion, nomAbogado, numColegiado);
			JOptionPane.showMessageDialog(this,mjs,"Mensaje",JOptionPane.INFORMATION_MESSAGE);
			txtBusqueda.setText("");
			txtNomAbogado.setText("");
			txtNumIdentificacion.setText("");
			txtNumColegiado.setText("");
		}
	}
	
	private void btnRegresar_actionPerformed(ActionEvent evt) {
		PantallaPrincipal PP=new PantallaPrincipal();
		PP.setVisible(true);
		PantallaModificarAbogado.this.dispose();
		
	}
}
