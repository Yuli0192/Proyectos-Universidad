package capaPresentacion;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;

import javax.swing.WindowConstants;
import javax.swing.SwingUtilities;

import capaLogica.Comunidad;
import capaLogica.Gestor;


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
public class PantallaEliminarComunidad extends javax.swing.JFrame {
	private JTextField txtBusqueda;
	private JTextField txtNombre;
	private JButton btnRegresar;
	private JButton btnEliminar;
	private JLabel nom;
	private JTextField txtNumComunidad;
	private JLabel numComunidad;
	private JButton btnBuscar;
	private Gestor gestor;
	/**
	* Auto-generated main method to display this JFrame
	*/
	public static void main(String[] args) {
		SwingUtilities.invokeLater(new Runnable() {
			public void run() {
				PantallaEliminarComunidad inst = new PantallaEliminarComunidad();
				inst.setLocationRelativeTo(null);
				inst.setVisible(true);
			}
		});
	}
	
	public PantallaEliminarComunidad() {
		super();
		initGUI();
		gestor=new Gestor();
	}
	
	private void initGUI() {
		try {
			setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE);
			getContentPane().setLayout(null);
			getContentPane().setBackground(new java.awt.Color(0,128,255));
			this.setIconImage(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/abo.jpg")).getImage());
			this.setTitle("Eliminar Comunidad");
			{
				txtBusqueda = new JTextField();
				getContentPane().add(txtBusqueda);
				txtBusqueda.setBounds(24, 39, 178, 23);
			}
			{
				btnBuscar = new JButton();
				getContentPane().add(btnBuscar);
				btnBuscar.setText("Buscar");
				btnBuscar.setBounds(214, 30, 141, 39);
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
				numComunidad = new JLabel();
				getContentPane().add(numComunidad);
				numComunidad.setText("Numero Comunidad");
				numComunidad.setBounds(24, 80, 121, 22);
			}
			{
				txtNumComunidad = new JTextField();
				getContentPane().add(txtNumComunidad);
				txtNumComunidad.setBounds(152, 80, 203, 23);
			}
			{
				nom = new JLabel();
				getContentPane().add(nom);
				nom.setText("Nombre");
				nom.setBounds(24, 123, 103, 23);
			}
			{
				txtNombre = new JTextField();
				getContentPane().add(txtNombre);
				txtNombre.setBounds(152, 123, 203, 23);
			}
			{
				btnEliminar = new JButton();
				getContentPane().add(btnEliminar);
				btnEliminar.setText("Eliminar");
				btnEliminar.setBounds(24, 172, 128, 42);
				btnEliminar.setBackground(new java.awt.Color(255,255,255));
				btnEliminar.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/modificar.gif")));
				btnEliminar.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnEliminar.actionPerformed, event="+evt);
						//TODO add your code for btnEliminar.actionPerformed
						btnEliminar_actionPerformed(evt);
					}
				});
			}
			{
				btnRegresar = new JButton();
				getContentPane().add(btnRegresar);
				btnRegresar.setText("Regresar");
				btnRegresar.setBounds(220, 174, 135, 40);
				btnRegresar.setBackground(new java.awt.Color(255,255,255));
				btnRegresar.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/salir.gif")));
				btnRegresar.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnRegresar.actionPerformed, event="+evt);
						//TODO add your code for btnRegresar.actionPerformed
						btnRegresar_actionPerformed(evt);
					}
				});
			}
			pack();
			this.setSize(400, 278);
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	private void btnEliminar_actionPerformed(ActionEvent evt) {
		String numComunidad,mjs;	
		try {
			numComunidad=txtNumComunidad.getText();
			//System.out.println(numComunidad);
			gestor.borrarComunidad(numComunidad);
			txtBusqueda.setText("");
			txtNumComunidad.setText("");
			txtNombre.setText("");
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	private void btnBuscar_actionPerformed(ActionEvent evt) {
		String numComunidad;
		Comunidad comunidad;
		try {
			numComunidad=txtBusqueda.getText();
			comunidad=gestor.buscarComunidad(numComunidad);
			txtNumComunidad.setText(comunidad.getNumComunidad());
			txtNombre.setText(comunidad.getNomComunidad());
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
	}
	private void btnRegresar_actionPerformed(ActionEvent evt) {
		PantallaPrincipal PP= new PantallaPrincipal();
		PP.setVisible(true);
		PantallaEliminarComunidad.this.dispose();
	}
}
